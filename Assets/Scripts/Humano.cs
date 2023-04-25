using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    CharacterController controller;

    public float speed = 10.0f;

    public string nombre { get; set; }

    public bool fpCameraStatus = true;
    public Camera fpCamera;
    public Camera tpCamera;

    private void Awake()
    {
        nombre = "Mario";
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            fpCameraStatus = !fpCameraStatus;
            fpCamera.enabled = fpCameraStatus;
            tpCamera.enabled = !fpCameraStatus;
        }


        float moveForward = Input.GetAxis("Vertical");
        float moveSide = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * moveSide + transform.forward * moveForward;

        controller.Move(move * speed * Time.deltaTime);
    }
}
