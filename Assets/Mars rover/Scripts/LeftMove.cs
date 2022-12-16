using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public GameObject Player;
    public float Force;
    public float turnSpeed = 0.5f;
    
    // Update is called once per frame and used to rotate the player to the left if the button is pressed
    void Update()
    {
        if(isPressed)
        {
            //Player.transform.Translate(Force * Time.deltaTime, 0, 0);
            Player.transform.Rotate(0, Force * turnSpeed, 0);
            
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

     public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    
}

