using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    public float minSpeed = 5f;
    public float maxSpeed = 10f;

    Rigidbody rb;
    Transform tr;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        rb.velocity = new Vector3(speed, speed, 0f);
    }

    private void Update()
    {
        Vector3 velocity = rb.velocity;

        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);

        rb.velocity = velocity.normalized * clampedSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 playerPos = collision.transform.position;

            Vector3 ballPos = tr.position;

            Vector3 direction = (ballPos - playerPos).normalized;

            float speed = rb.velocity.magnitude;

            rb.velocity = direction * speed;
        }
    }
}
