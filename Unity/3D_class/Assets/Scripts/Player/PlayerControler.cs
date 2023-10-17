using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    [SerializeField] protected PlayerCtrlSupport support;
    [SerializeField] protected PlayerCtrlVariables variables;
    [SerializeField] protected PlayerCtrlCamera playerCtrlCamera;

    // Player body rigidbody
    [SerializeField] protected Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        support = GetComponent<PlayerCtrlSupport>();
        variables = GetComponent<PlayerCtrlVariables>();
        rb = GetComponent<Rigidbody>();
        playerCtrlCamera = GetComponent<PlayerCtrlCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        support.GetInput();
        playerCtrlCamera.CameraController();
    }
}
