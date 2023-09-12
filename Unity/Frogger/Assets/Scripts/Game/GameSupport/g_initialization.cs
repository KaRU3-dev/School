using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FloggerGame
{
    public class g_initialization : GameMain
    {
        /// <summary>
        /// Game variables initialization
        /// </summary>
        public void InitVariables()
        {

            // Set game start bool to true(game is start)
            g_variables.Start = true;

            // Set game limit to 300(5min)
            g_variables.GameTime = 300f;

            // Set goal status to false(not goaled)
            g_variables.Goal1 = false;
            g_variables.Goal2 = false;
            g_variables.Goal3 = false;
            g_variables.Goal4 = false;
            g_variables.Goal5 = false;

            // Set player max life to 3
            g_variables.PlayerMaxLife = 3;
        }
    }
}

