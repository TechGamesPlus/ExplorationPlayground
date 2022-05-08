using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTrigger : MonoBehaviour
{
    public GameObject OfficeTrigger;
    public GameObject FacilityTrigger;

    void OnTriggerEnter(Collider other)
    {
        OfficeTrigger.SetActive(true);
        FacilityTrigger.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        OfficeTrigger.SetActive(false);
        FacilityTrigger.SetActive(false);
    }

    void Start()
    {
        OfficeTrigger.SetActive(false);
        FacilityTrigger.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("9"))
        {
            if (OfficeTrigger.activeSelf)
            {
                SceneManager.LoadScene("Playground");
                Cursor.lockState = CursorLockMode.None;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (Input.GetKeyDown("0"))
        {
            if (FacilityTrigger.activeSelf)
            {
                SceneManager.LoadScene("Playground");
                Cursor.lockState = CursorLockMode.None;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
