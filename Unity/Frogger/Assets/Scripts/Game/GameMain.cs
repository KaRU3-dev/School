using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

ToDo:
    Create generator for cars
    Create generator for woods from left / right
    Create generator for clabs from left / right

    Create checker for player object is goal

    Create player kill method
 
*/

namespace FloggerGame
{
    public class GameMain : MonoBehaviour
    {
        g_initialization GameInit = new();

        private void Start()
        {
            // Initialize variables
            GameInit.InitVariables();
        }
    }
}