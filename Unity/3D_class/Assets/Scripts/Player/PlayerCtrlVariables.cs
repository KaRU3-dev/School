using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlVariables : PlayerControler
{
    // Get script
    void Awake()
    {
        support = GetComponent<PlayerCtrlSupport>();
        variables = GetComponent<PlayerCtrlVariables>();
        rb = GetComponent<Rigidbody>();
        playerCtrlCamera = GetComponent<PlayerCtrlCamera>();
    }

    // Player speed
    public float speed = 12f;

    // Mouse sensitivity
    public float mouseSensitivity = 100f;
    // Xrotation
    public float xRotation = 0f;
}
