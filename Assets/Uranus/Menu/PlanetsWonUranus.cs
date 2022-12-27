using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetsWonUranus : MonoBehaviour
{

    public Text planetsWon;
    UranusLife uranusLife;
    [SerializeField] private GameObject uranus;
    private const int  three = 3;
    private const int two = 2;
    private const int one = 1;
    public int numberOfPlanets = 0;

    // Start is called before the first frame update
    void Start()
    {
       uranusLife = uranus.GetComponent<UranusLife>();   
    }

    // Update is called once per frame
    void Update()
    {
        PlanetsWon();
    }

    public void PlanetsWon()
    {
        if (uranusLife.currentHealth == uranusLife.maxHealth)
        {
            planetsWon.text = three.ToString();
            numberOfPlanets = three;
        }
        else if (uranusLife.currentHealth < uranusLife.maxHealth && uranusLife.currentHealth >= (uranusLife.maxHealth / 2))
        {
            planetsWon.text = two.ToString();
            numberOfPlanets = two;
        }
        else if (uranusLife.currentHealth < (uranusLife.maxHealth / 2) && uranusLife.currentHealth > 0)
        {
            planetsWon.text = one.ToString();
            numberOfPlanets = one;
        }
    }

}
