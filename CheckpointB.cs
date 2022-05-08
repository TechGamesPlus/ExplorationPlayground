using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointB : MonoBehaviour
{
    public GameObject ManipulationBEAN2;
    public GameObject HideID;

    void Start()
    {
        ManipulationBEAN2.SetActive(false);
        HideID.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (HideID.activeSelf)
        {
            return;
        }

        ManipulationBEAN2.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        ManipulationBEAN2.SetActive(false);
        HideID.SetActive(true);
    }
}
