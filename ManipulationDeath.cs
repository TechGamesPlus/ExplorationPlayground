using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManipulationDeath : MonoBehaviour
{
    public GameObject DeathUI;

    void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        DeathUI.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        DeathUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PreviousLevel()
    {
        Time.timeScale = 1f;
        DeathUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        DeathUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
