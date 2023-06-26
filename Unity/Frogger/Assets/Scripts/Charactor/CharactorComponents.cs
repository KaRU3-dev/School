using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorComponents : MonoBehaviour
{
    /// <summary>
    /// Foot speed
    /// <para>If key input once, increase/decrease pos</para>
    /// <para>Use in move to vertical or horizontal</para>
    /// <para>Type: float</para>
    /// 
    /// <code>
    /// #Example Code
    /// if (Input.GetKeyDown(KeyCode.D)
    /// {
    ///     transform.position += Vector3.right * FootSpeed * Time.deltaTime;
    /// }
    /// </code>
    /// </summary>
    public float FootSpeed;
    /// <summary>
    /// Target position to move
    /// <para>If key input, get and set target position</para>
    /// <para>Use move on vertical and horizontal</para>
    /// <para>Type: Vector3</para>
    /// 
    /// <code>
    /// #Example Code
    /// if (Input.GetKeyDown(KeyCode.D)
    /// {
    ///     for (posDiff != MoveTargetPos)
    ///     {
    ///         ...
    ///     }
    /// }
    /// </code>
    /// </summary>
    public Vector3 MoveTargetPos;

    /// <summary>
    /// PlayerStatus
    /// <para>0: Idle</para>
    /// <para>1: Jump</para>
    /// </summary>
    public enum PlayerStatus
    {
        /// <summary>
        /// Status: Idle
        /// </summary>
        PlayerIdling,
        /// <summary>
        /// Status: Jump or move
        /// </summary>
        PlayerJumping
    }
    /// <summary>
    /// Player body idling
    /// </summary>
    public GameObject PlayerIdle;
    /// <summary>
    /// Player body jumping
    /// </summary>
    public GameObject PlayerJump;
}
