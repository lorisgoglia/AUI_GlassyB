using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameLoader : MonoBehaviour
{
    public GameObject sunnyScene;
    public GameObject uranusScene;

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

}
