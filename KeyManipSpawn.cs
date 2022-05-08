using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManipSpawn : MonoBehaviour
{
    public GameObject BEANS;
    public GameObject Key;

    void Start()
    {
        BEANS.SetActive(false);
        Key.SetActive(false);
    }

    void Update()
    {
        if (Key.activeSelf)
        {
            BEANS.SetActive(true);
        }
    }
}
