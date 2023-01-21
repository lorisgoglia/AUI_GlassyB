using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NRKernal.NRExamples;
using NRKernal;


public class BeamGestures : MonoBehaviour
{
    [SerializeField] private GameObject laser;
    [SerializeField] private GameObject winPrefab;
    [SerializeField] private GameObject overPrefab;
    [SerializeField] private GameObject pausePrefab;
    [SerializeField] private GameObject menu;
    [SerializeField] private float laserDuration = 3f;
    private bool isOpen;
    private Pose rightHandPose;
    private Pose rightHandPointerPose;
    private Pose leftHandPose;
    private Pose leftHandPointerPose;
    public bool lockLaser = true;
    public bool lockPause = true;

    //[SerializeField] private GameObject pauseBtn;

    /*
    private void Awake()
    {
        laser = GameObject.FindGameObjectWithTag("laser");

    }*/

    private void Start()
    {
        WaitStart();
    }

    public void WaitStart()
    {
        StartCoroutine(WaitForStart());
    }

    IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(4);
        lockLaser = false;
        lockPause = false;
    }
    

    IEnumerator LaserDeactivator()
    {
        if ((!isOpen) && (winPrefab.activeInHierarchy == false && overPrefab.activeInHierarchy == false && pausePrefab.activeInHierarchy == false) && lockLaser ==false)
        {
            laser.SetActive(true);
            SoundManagerScript.PlaySound("beam");
            yield return new WaitForSeconds(laserDuration);
            laser.SetActive(false);
        }
    }

    private void Update()
    {
        //mano destra
        HandState rightHandState = NRInput.Hands.GetHandState(HandEnum.RightHand);
        if (rightHandState == null)
            return;

        switch (rightHandState.currentGesture)
        {
            case HandGesture.Point:
                /*if (lockLaser == false)
                {
                    menu.SetActive(true);
                    winPrefab.SetActive(false);
                    pausePrefab.SetActive(true);
                    overPrefab.SetActive(false);
                }*/
                break;
            case HandGesture.Grab:
                //laser.GetComponent<MeshRenderer>().enabled = false;
                isOpen = false;
                //SoundManagerScript.PlaySound("reloading");
                laser.SetActive(false);
                //pauseBtn.SetActive(false);
                break; 
            case HandGesture.Victory:
                break;
            case HandGesture.OpenHand:
                //laser.SetActive(true);
                StartCoroutine(LaserDeactivator());
                isOpen = true;
                //laser.GetComponent<MeshRenderer>().enabled = true;
                //pauseBtn.SetActive(true);
                break;
            default:
                //laser.GetComponent<MeshRenderer>().enabled = false;
                laser.SetActive(false);
                //pauseBtn.SetActive(false);
                break;
        }

        
        //mano sinistra
        HandState leftHandState = NRInput.Hands.GetHandState(HandEnum.LeftHand);
        if (leftHandState == null)
            return;
        
        switch(leftHandState.currentGesture)
        {
            case HandGesture.Point:
                break;
            case HandGesture.Grab:
            break; 
            case HandGesture.Victory:
                break;
            case HandGesture.OpenHand:
                if (lockPause == false)
                {
                    menu.SetActive(true);
                    pausePrefab.SetActive(true);
                    winPrefab.SetActive(false);
                    overPrefab.SetActive(false);
                }
                break;
            default:
                //pauseBtn.SetActive(false);
                //pausePrefab.SetActive(false);
            break;
        }
        
        //Questa parte serve a gestire il movimento del laser
        rightHandPose = rightHandState.GetJointPose(HandJointID.Palm);
        rightHandPointerPose = rightHandState.pointerPose;
        laser.transform.SetPositionAndRotation(rightHandPose.position, rightHandPointerPose.rotation);

        /*
        //Questa parte serve a gestire il movimento del bottone
        pauseBtn.SetActive(true);
        leftHandPose = leftHandState.GetJointPose(HandJointID.Palm);
        leftHandPointerPose = leftHandState.pointerPose;
        pauseBtn.transform.SetPositionAndRotation(leftHandPose.position, leftHandPointerPose.rotation);
        */

        //Questa parte serve a gestire la pausa
        //if (pauseBtn.activeInHierarchy) pausePrefab.SetActive(true);
    }

    public void GoPause()
    {
        if (lockLaser == false)
        {
            menu.SetActive(true);
            winPrefab.SetActive(false);
            pausePrefab.SetActive(true);
            overPrefab.SetActive(false);
        }
    }

}
