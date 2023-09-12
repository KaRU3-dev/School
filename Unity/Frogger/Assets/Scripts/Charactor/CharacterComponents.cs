using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterComponents : MonoBehaviour
{
    [Tooltip("Player Move")]
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

    [Tooltip("Player Status")]
    /// <summary>
    /// PlayerStatus
    /// <para>0: Idle</para>
    /// <para>1: Jump</para>
    /// <para>2: Death</para>
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
        PlayerJumping,
        /// <summary>
        /// Status: Death or GameOver
        /// </summary>
        PlayerDeath
    }
    /// <summary>
    /// Player body for idling
    /// </summary>
    public GameObject PlayerIdle;
    /// <summary>
    /// Player body for jumping
    /// </summary>
    public GameObject PlayerJump;
    /// <summary>
    /// Player body for death or gameover
    /// </summary>
    public GameObject PlayerDeath;
    /// <summary>
    /// Amount of player life
    /// <para>Default: 3</para>
    /// <para>CAUTION: This variable will move to GameController </para>
    /// </summary>
    public int PlayerLife;
    /// <summary>
    /// Player's health
    /// </summary>
    public int PlayerHealth;
}
