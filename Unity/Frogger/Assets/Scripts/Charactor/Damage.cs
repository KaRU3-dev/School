using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : CharacterController
{
    // If collision enter with object tag "Cars", Get damage 100.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cars"))
        {
            Components.PlayerHealth -= 100;
        }
    }
}
