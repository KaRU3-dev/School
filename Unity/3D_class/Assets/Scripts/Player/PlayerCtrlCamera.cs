using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlCamera : PlayerControler
{
    // Camera
    [SerializeField] protected Camera playerCamera;

    // Get script
    void Awake()
    {
        support = GetComponent<PlayerCtrlSupport>();
        variables = GetComponent<PlayerCtrlVariables>();
        rb = GetComponent<Rigidbody>();
        playerCamera = GetComponentInChildren<Camera>();
        playerCtrlCamera = GetComponent<PlayerCtrlCamera>();
    }

    // 3rd person camera controller (use camera)
    public void CameraController()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * variables.mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * variables.mouseSensitivity * Time.deltaTime;

        // Rotate player body
        transform.Rotate(Vector3.up * mouseX);

        // Rotate camera
        variables.xRotation -= mouseY;
        variables.xRotation = Mathf.Clamp(variables.xRotation, -90f, 90f);

        // Rotate camera
        playerCamera.transform.localRotation = Quaternion.Euler(variables.xRotation, 0f, 0f);
    }
}
