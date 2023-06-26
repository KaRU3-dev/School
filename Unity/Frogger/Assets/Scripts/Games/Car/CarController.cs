using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float CarSpeed;
    [SerializeField] private bool IsRight;

    private void Update()
    {
        if (!IsRight)
        {
            transform.position += Vector3.left * CarSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.right * CarSpeed * Time.deltaTime;
        }

    }

    private void destroyCar()
    {
        Destroy(gameObject);
    }
}
