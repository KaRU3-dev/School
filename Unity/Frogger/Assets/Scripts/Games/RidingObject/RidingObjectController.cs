using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidingObjectController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private float Speed;
    [SerializeField] private bool GoRight;

    private void Update()
    {
        if (GoRight)
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }
    }
}
