using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointD : MonoBehaviour
{
    public GameObject ManipulationBEAN4;
    public GameObject HideID;

    void Start()
    {
        ManipulationBEAN4.SetActive(false);
        HideID.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (HideID.activeSelf)
        {
            return;
        }

        ManipulationBEAN4.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        ManipulationBEAN4.SetActive(false);
        HideID.SetActive(true);
    }
}