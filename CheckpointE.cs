using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointE : MonoBehaviour
{
    public GameObject DeathUI;
    public GameObject ManipBEAN;

    void Start()
    {
        ManipBEAN.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        ManipBEAN.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        DeathUI.SetActive(true);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        DeathUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
