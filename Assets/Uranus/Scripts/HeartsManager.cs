using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsManager : MonoBehaviour
{

    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;
    [SerializeField] private GameObject heart4;
    [SerializeField] private GameObject heart5;
    UranusLife uranusLife;
    [SerializeField] private GameObject uranus;
    [SerializeField] private GameObject winMenu;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameObject pauseMenu;
    public float rotSpeed = 0.1f;


    private void Awake()
    {
        uranusLife = uranus.GetComponent <UranusLife>();
    }

    // Update is called once per frame
    void Update()
    {
        numberOfHearts();
        heartsMovement();
        heartsSpeed();
    }

    void numberOfHearts()
    {
        if (uranusLife.currentHealth == 6)
        {
            if (winMenu.activeInHierarchy == false && gameOverMenu.activeInHierarchy == false)
            {
                heart.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(true);
                heart5.SetActive(true);
            }
            else
            {
                heart.SetActive(false);
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                heart4.SetActive(false);
                heart5.SetActive(false);
            }
        }
        else if (uranusLife.currentHealth == 5)
        {
            heart.SetActive(true);
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            heart4.SetActive(true);
            heart5.SetActive(false);
        }
        else if (uranusLife.currentHealth == 4)
        {
            heart.SetActive(false);
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            heart4.SetActive(true);
            heart5.SetActive(false);
        }
        else if (uranusLife.currentHealth == 3)
        {
            heart.SetActive(false);
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        else if (uranusLife.currentHealth == 2)
        {
            heart.SetActive(false);
            heart1.SetActive(false);
            heart2.SetActive(true);
            heart3.SetActive(true);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        else if (uranusLife.currentHealth == 1)
        {
            heart.SetActive(false);
            heart1.SetActive(false);
            heart2.SetActive(true);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        else if (uranusLife.currentHealth == 0)
        {
            heart.SetActive(false);
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        else
        {
            heart.SetActive(false);
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
    }

    void heartsMovement()
    {
        if(pauseMenu.activeInHierarchy == false)
        {
            heart.transform.Rotate(0, 0, rotSpeed);
            heart1.transform.Rotate(0, 0, -rotSpeed);
            heart2.transform.Rotate(0, 0, rotSpeed);
            heart3.transform.Rotate(0, 0, -rotSpeed);
            heart4.transform.Rotate(0, 0, rotSpeed);
            heart5.transform.Rotate(0, 0, -rotSpeed);
        }
        else
        {
            heart.transform.Rotate(0, 0, 0);
            heart1.transform.Rotate(0, 0, 0);
            heart2.transform.Rotate(0, 0, 0);
            heart3.transform.Rotate(0, 0, 0);
            heart4.transform.Rotate(0, 0, 0);
            heart5.transform.Rotate(0, 0, 0);
        }
    }

    void heartsSpeed()
    {
        if (uranusLife.currentHealth == uranusLife.maxHealth) rotSpeed = 0.2f;
        else if (uranusLife.currentHealth > uranusLife.maxHealth/2) rotSpeed = 0.4f;
        else if (uranusLife.currentHealth == uranusLife.maxHealth) rotSpeed = 0.6f;
        else if (uranusLife.currentHealth < uranusLife.maxHealth/2) rotSpeed = 0.8f;
    }
}
