using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Vector3 colPos;
    [SerializeField] private GameObject explosionPrefab;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Uranus"))
        {
            gameObject.SetActive(false);
            colPos = gameObject.transform.position;
            Instantiate(explosionPrefab, colPos, Quaternion.identity);

        }

        if (other.gameObject.CompareTag("NoiseTarget"))
        {
            gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("laser"))
        {
            gameObject.SetActive(false);
        }

                /*
        if (other.gameObject.CompareTag("NoiseTarget"))
        {
            Destroy(gameObject);
        }
        */
    }

}
