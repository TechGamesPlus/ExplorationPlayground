using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject WinnerMenu;

    void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        WinnerMenu.SetActive(true);
    }
}
