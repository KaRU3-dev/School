using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidingObjectDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObjectLimits"))
        {
            Destroy(gameObject);
        }
    }
}
