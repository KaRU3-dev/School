using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlSupport : PlayerControler
{
    // Get script
    void Awake()
    {
        support = GetComponent<PlayerCtrlSupport>();
        variables = GetComponent<PlayerCtrlVariables>();
        rb = GetComponent<Rigidbody>();
        playerCtrlCamera = GetComponent<PlayerCtrlCamera>();
    }

    #region Input
    // Get input
    public void GetInput()
    {
        // If input w key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        // If input s key is pressed
        else if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }

        // If input a key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        // If input d key is pressed
        else if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
    }
    #endregion

    #region Forwards
    // Move forward with input w key * speed (use rigidbody)
    public void MoveForward()
    {
        rb.velocity = transform.forward * variables.speed;
    }
    #endregion
    #region Backwards
    // Move forward with input w key * speed (use rigidbody)
    public void MoveBackward()
    {
        rb.velocity = -transform.forward * variables.speed;
    }
    #endregion

    #region Right
    // Move forward with input a key * speed (use rigidbody)
    public void MoveRight()
    {
        rb.velocity = transform.right * variables.speed;
    }
    #endregion
    #region Left
    // Move forward with input d key * speed (use rigidbody)
    public void MoveLeft()
    {
        rb.velocity = -transform.right * variables.speed;
    }
    #endregion

}
