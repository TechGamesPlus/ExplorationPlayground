using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FacilityTriggered : MonoBehaviour
{
    public GameObject FacilityTrigger;

    void OnTriggerEnter(Collider other)
    {
        FacilityTrigger.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        FacilityTrigger.SetActive(false);
    }

    void Start()
    {
        FacilityTrigger.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown("0"))
        {
            if (FacilityTrigger.activeSelf)
            {
                SceneManager.LoadScene("Maze0");
                Cursor.lockState = CursorLockMode.None;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
