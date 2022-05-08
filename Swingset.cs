using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swingset : MonoBehaviour
{
    public GameObject MainBEAN;
    public GameObject FollowerBEAN;
    public GameObject SwingBEAN;
    public GameObject SFBEAN;
    public GameObject SwingCam;
    public GameObject SwingChains;

    void Start()
    {
        MainBEAN.SetActive(true);
        FollowerBEAN.SetActive(true);
        SwingBEAN.SetActive(false);
        SFBEAN.SetActive(false);
        SwingCam.SetActive(false);
        SwingChains.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown("2"))
        {
            MainBEAN.SetActive(false);
            FollowerBEAN.SetActive(false);
            SwingBEAN.SetActive(true);
            SFBEAN.SetActive(true);
            SwingCam.SetActive(true);
            SwingChains.SetActive(false);
        }

        if (Input.GetKeyDown("1"))
        {
            if (SwingBEAN.activeSelf)
            {
                Start();
            }

            else if (!SwingBEAN.activeSelf)
            {
                return;
            }
        }
    }
}
