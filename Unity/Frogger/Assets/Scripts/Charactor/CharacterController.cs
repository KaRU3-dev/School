using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    /// <summary>
    /// PlayerBody
    /// </summary>
    private GameObject PlayerBody;

    /// <summary>
    /// Character components
    /// <para>This variable is storing character's component</para>
    /// </summary>
    protected CharacterComponents Components;

    // Start is called before the first frame update
    void Start()
    {
        PlayerBody = GetComponent<GameObject>();
        Components = GetComponent<CharacterComponents>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            CharactorMoveToUp(GetCurrentPosition());
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            CharactorMoveToDown(GetCurrentPosition());
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CharactorMoveToLeft(GetCurrentPosition());
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            CharactorMoveToRight(GetCurrentPosition());
        }
    }

    private Vector3 GetCurrentPosition()
    {
        return transform.position;
    }

    private void CharactorMoveToUp(Vector3 pos)
    {
        transform.position = new Vector3(pos.x, pos.y, pos.z + Components.FootSpeed);
    }
    private void CharactorMoveToLeft(Vector3 pos)
    {
        transform.position = new Vector3(pos.x - Components.FootSpeed, pos.y, pos.z);
    }
    private void CharactorMoveToDown(Vector3 pos)
    {
        transform.position = new Vector3(pos.x, pos.y, pos.z - Components.FootSpeed);
    }
    private void CharactorMoveToRight(Vector3 pos)
    {
        transform.position = new Vector3(pos.x + Components.FootSpeed, pos.y, pos.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cars"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("River"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Goal"))
        {
            Destroy(gameObject);
        }
    }
}
