using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float CarSpeed;

    void Update()
    {
        transform.position += Vector3.left * CarSpeed * Time.deltaTime;
    }
}
