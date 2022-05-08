using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OfficeTriggered : MonoBehaviour
{
    public GameObject OfficeTrigger;

    void OnTriggerEnter(Collider other)
    {
        OfficeTrigger.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        OfficeTrigger.SetActive(false);
    }

    void Start()
    {
        OfficeTrigger.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown("9"))
        {
            if (OfficeTrigger.activeSelf)
            {
                SceneManager.LoadScene("Office");
                Cursor.lockState = CursorLockMode.None;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
