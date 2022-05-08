using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointA : MonoBehaviour
{
    public GameObject ManipulationBEAN1;

    void Start()
    {
        ManipulationBEAN1.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        ManipulationBEAN1.SetActive(false);
    }
}