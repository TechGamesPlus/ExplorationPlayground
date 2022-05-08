using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject TopDownCamera;
    public GameObject CakeCamera;
    public GameObject Follower;

    // Start is called before the first frame update
    void Start()
    {
        TopDownCamera.SetActive(false);
        CakeCamera.SetActive(false);
        Follower.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            if (!Follower.activeSelf)
            {
                TopDownCamera.SetActive(true);
                Follower.SetActive(false);
                return;
            }

            TopDownCamera.SetActive(true);
            Follower.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            if (!Follower.activeSelf)
            {
                Follower.SetActive(false);
                TopDownCamera.SetActive(false);
                return;
            }

            TopDownCamera.SetActive(false);
            Follower.SetActive(true);
        }

        if (Input.GetKeyDown("8"))
        {
            if (!Follower.activeSelf)
            {
                CakeCamera.SetActive(true);
                Follower.SetActive(false);
                return;
            }

            CakeCamera.SetActive(true);
            Follower.SetActive(true);
        }

        if (Input.GetKeyUp("8"))
        {
            if (!Follower.activeSelf)
            {
                Follower.SetActive(false);
                CakeCamera.SetActive(false);
                return;
            }

            CakeCamera.SetActive(false);
            Follower.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            if (!TopDownCamera.activeSelf)
            {
                TopDownCamera.SetActive(false);
            }

            else if (TopDownCamera.activeSelf)
            {
                TopDownCamera.SetActive(true);
            }

            if (Follower.activeSelf)
            {
                Follower.SetActive(false);
                return;
            }

            else if (!Follower.activeSelf)
            {
                Follower.SetActive(true);
                return;
            }
        }
    }
}