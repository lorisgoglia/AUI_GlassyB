using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameLoader : MonoBehaviour
{
    public GameObject sunnyScene;
    public GameObject uranusScene;
    public GameObject marsScene;

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
    }

    public void MarsToSunny()
    {
        marsScene.SetActive(false);
        sunnyScene.SetActive(true);
        //aggiungere codice per spostare camera in (0,0,0)
    }



}
