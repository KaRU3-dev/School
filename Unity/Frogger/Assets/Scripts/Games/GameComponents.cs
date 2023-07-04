using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComponents : MonoBehaviour
{
    [Header("Game Component")]
    /// <summary>
    /// In game time for generator timing
    /// </summary>
    public float CarDeltaT;
    /// <summary>
    /// In game time for generator timing
    /// </summary>
    public float RidingObjectDeltaT;
    /// <summary>
    /// Run car generator timing
    /// </summary>
    public float CarGenTiming;
    /// <summary>
    /// Run riding object generator timing
    /// </summary>
    public float RidingObjectGenTiming;
    /// <summary>
    /// CarGenerator.cs
    /// </summary>
    public CarGenerator CarGenerator;
    /// <summary>
    /// RidingObjectGenerator.cs
    /// </summary>
    public RidingObjectGenerater RidingObjectGenerator;

    [Header("Player")]
    /// <summary>
    /// Player life
    /// <para>Default: 3</para>
    /// </summary>
    public int PlayerLife;
    /// <summary>
    /// Amount of player goals
    /// <para>Default: 0</para>
    /// <code>
    /// # Example code
    /// if (GameObject.compareTag == "goal")
    /// {
    ///    PlayerGoals += 1;
    /// }
    /// 
    /// </code>
    /// </summary>
    public int PlayerGoals;
    /// <summary>
    /// GameObject for player
    /// </summary>
    public GameObject PlayerBody;

    [Header("Goal status")]
    /// <summary>
    /// Status for goal one
    /// <para>If goaled = true</para>
    /// <para>If not goaled or default = false</para>
    /// </summary>
    public bool GoalOneStatus;
    /// <summary>
    /// Status for goal two
    /// <para>If goaled = true</para>
    /// <para>If not goaled or default = false</para>
    /// </summary>
    public bool GoalTwoStatus;
    /// <summary>
    /// Status for goal three
    /// <para>If goaled = true</para>
    /// <para>If not goaled or default = false</para>
    /// </summary>
    public bool GoalThreeStatus;
    /// <summary>
    /// Status for goal four
    /// <para>If goaled = true</para>
    /// <para>If not goaled or default = false</para>
    /// </summary>
    public bool GoalFourStatus;
    /// <summary>
    /// Status for goal five
    /// <para>If goaled = true</para>
    /// <para>If not goaled or default = false</para>
    /// </summary>
    public bool GoalFiveStatus;
}
