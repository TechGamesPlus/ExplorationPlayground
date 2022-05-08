using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldPlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public GameObject SloMoPanel;

    public float speed = 12f;
    public float gravity = 9.81f;
    public float jumpHeight = 3f;

    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -3f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 30f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 12f;
        }

        if (Input.GetKeyDown("5"))
        {
            speed = 50f;
            base.transform.localScale = new Vector3(1.2f, 0.6f, 1.2f);
        }

        if (Input.GetKeyDown("4"))
        {
            speed = 12f;
            base.transform.localScale = new Vector3(1.2f, 1.8f, 1.2f);
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed = 7f;
            base.transform.localScale = new Vector3(1.2f, 1f, 1.2f);
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = 12f;
            base.transform.localScale = new Vector3(1.2f, 1.8f, 1.2f);
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            x = 0f;
            z = 0f;
        }

        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            Time.timeScale = 0.25f;
            SloMoPanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            Time.timeScale = 1f;
            SloMoPanel.SetActive(false);
        }
    }
}
