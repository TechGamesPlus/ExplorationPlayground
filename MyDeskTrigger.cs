using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyDeskTrigger : MonoBehaviour
{
    public GameObject Updater;
    public GameObject ShopOnlineA;
    public GameObject Milk;

    void OnTriggerEnter(Collider other)
    {
        Updater.SetActive(true);
    }

    void Start()
    {
        Updater.SetActive(false);
        Milk.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Updater.activeSelf)
            {
                ShopOnlineA.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
            }
        }
    }

    public void BuyMilk()
    {
        Milk.SetActive(true);
        ShopOnlineA.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SellMilk()
    {
        if (!Milk.activeSelf)
        {
            SceneManager.LoadScene("Playground");
            Application.Quit();
        }

        Milk.SetActive(false);
        ShopOnlineA.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ShopExit()
    {
        ShopOnlineA.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    void OnTriggerExit(Collider other)
    {
        Updater.SetActive(false);
    }


}
