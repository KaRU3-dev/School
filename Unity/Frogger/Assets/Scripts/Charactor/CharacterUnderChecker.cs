using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CharactorUnderChecker : MonoBehaviour
{
    private bool RaycastFireToUnder()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            if (hit.collider.gameObject.CompareTag("StartPos"))
            {
                return true;
            }
            else if (hit.collider.gameObject.CompareTag("MidPos"))
            {
                return true;
            }
            else if (hit.collider.gameObject.CompareTag("Road"))
            {
                return true;
            }
            else if (hit.collider.gameObject.CompareTag("RidingObject"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
