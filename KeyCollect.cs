using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public GameObject Key;
    public GameObject Pouch;

    void OnTriggerEnter(Collider other)
    {
        Key.SetActive(true);
        Pouch.SetActive(false);
    }
}
