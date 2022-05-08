using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointC : MonoBehaviour
{
    public GameObject ManipulationBEAN3;
    public GameObject HideID;

    void Start()
    {
        ManipulationBEAN3.SetActive(false);
        HideID.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (HideID.activeSelf)
        {
            return;
        }

        ManipulationBEAN3.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        ManipulationBEAN3.SetActive(false);
        HideID.SetActive(true);
    }
}