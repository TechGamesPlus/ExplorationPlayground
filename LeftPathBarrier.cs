using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPathBarrier : MonoBehaviour
{
    public GameObject LeftID;
    public GameObject LeftBarrier;

    void Start()
    {
        LeftID.SetActive(false);
        LeftBarrier.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (LeftID.activeSelf)
        {
            return;
        }

        LeftID.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        LeftBarrier.SetActive(true);
    }
}
