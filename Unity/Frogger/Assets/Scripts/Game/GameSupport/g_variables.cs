using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FloggerGame
{
    public class g_variables : MonoBehaviour
    {
        /// <summary>
        /// Game is run? status
        /// </summary>
        public static bool Start { get; set; } = false;
        /// <summary>
        /// Game limit time
        /// </summary>
        /// <value>Default is 300f(5min)</value>
        public static float GameTime { get; set; } = 300f;
        /// <summary>
        /// 1 life time
        /// </summary>
        /// <value>Default is 90f(1.5min)</value>
        public static float PerLifeTime { get; set; } = 90f;

        /// <summary>
        /// Temporary count variable
        /// </summary>
        public static int Cnt1 { get; set; } = 0;

        /// <summary>
        /// Goal 1 status boolean
        /// </summary>
        /// <value>Default is false( not goaled)</value>
        public static bool Goal1 { get; set; } = false;
        /// <summary>
        /// Goal 2 status boolean
        /// </summary>
        /// <value>Default is false( not goaled)</value>
        public static bool Goal2 { get; set; } = false;
        /// <summary>
        /// Goal 3 status boolean
        /// </summary>
        /// <value>Default is false( not goaled)</value>
        public static bool Goal3 { get; set; } = false;
        /// <summary>
        /// Goal 4 status boolean
        /// </summary>
        /// <value>Default is false( not goaled)</value>
        public static bool Goal4 { get; set; } = false;
        /// <summary>
        /// Goal 5 status boolean
        /// </summary>
        /// <value>Default is false( not goaled)</value>
        public static bool Goal5 { get; set; } = false;

        /// <summary>
        /// Player's body
        /// </summary>
        public GameObject PlayerBody;
        /// <summary>
        /// Player's max life
        /// </summary>
        /// <value>Default is 3</value>
        public static int PlayerMaxLife { get; set; } = 3;

        /// <summary>
        /// Player's generation position
        /// </summary>
        public GameObject PlayerGenPos;
    }
}
