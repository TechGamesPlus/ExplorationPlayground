using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPathBarrier : MonoBehaviour
{
    public GameObject RightID;
    public GameObject RightBarrier;

    void Start()
    {
        RightID.SetActive(false);
        RightBarrier.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (RightID.activeSelf)
        {
            return;
        }

        RightID.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        RightBarrier.SetActive(true);
    }
}
