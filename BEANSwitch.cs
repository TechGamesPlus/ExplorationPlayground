using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEANSwitch : MonoBehaviour
{
    [SerializeField] private GameObject OLDBEAN;
    [SerializeField] private GameObject NEWBEAN;

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            OLDBEAN.SetActive(true);
            NEWBEAN.SetActive(false);
        }

        if (Input.GetKeyDown("2"))
        {
            OLDBEAN.SetActive(false);
            NEWBEAN.SetActive(true);
        }
    }
}
