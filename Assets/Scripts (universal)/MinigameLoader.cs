using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameLoader : MonoBehaviour
{
    public GameObject sunnyScene;
    public GameObject uranusScene;
    public GameObject marsScene;
    public FollowCamera followScript;
    public GameObject rover;
    public GameObject camera;
    private void Start()
    {
    }


    public void SunnyToUranus()
    {
        sunnyScene.SetActive(false);
        uranusScene.SetActive(true);
    }

    public void UranusToSunny()
    {
        uranusScene.SetActive(false);
        sunnyScene.SetActive(true);
    }

    public void SunnyToMars()
    {

        sunnyScene.SetActive(false);
        marsScene.SetActive(true);
        //aggiungere codice per spostare camera come figlio del rover
        //followScript.enabled = true;
        camera.transform.parent = rover.transform;
        resetPosition();


        //object1 is now the child of object2
    }

    public void MarsToSunny()
    {
        camera.transform.parent = null;
        marsScene.SetActive(false);
        sunnyScene.SetActive(true);
        //aggiungere codice per spostare camera in (0,0,0)
        //followScript.resetPosition();
        //followScript.enabled = false;
        resetPosition();

    }

    private void resetPosition()
    {
        camera.transform.position = new Vector3(0, 0, 0);
    }



}
