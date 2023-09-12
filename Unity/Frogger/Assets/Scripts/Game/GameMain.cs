using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FloggerGame
{
    public class GameMain : MonoBehaviour
    {
        g_initialization GameInit = new();
        g_variables g_variables = new();

        // Life map
        private int[,] LifeMap = new int[g_variables.PlayerMaxLife, g_variables.PlayerMaxLife];

        private void Start()
        {
            // Initialize variables
            GameInit.InitVariables();

            // Life initialize
            for (int i = 0; i < g_variables.PlayerMaxLife; i++)
            {
                for (int j = 0; j < g_variables.PlayerMaxLife; j++)
                {
                    LifeMap[i, j] = 1;
                }
            }

            // Init player
            g_variables.PlayerBody = GetComponent<GameObject>();

            // Generate player
            Instantiate(g_variables.PlayerBody);
            // Move to gen pos
            g_variables.PlayerBody.transform.position = g_variables.PlayerGenPos.transform.position;
        }

        private void Update()
        {
            if (GameObject.FindWithTag("Player") == null)
            {
                // Life map player{Cnt1 - 1} is dead
                LifeMap[g_variables.Cnt1, g_variables.Cnt1] = 0;
            }

            if (g_variables.PlayerMaxLife != 0 && GameObject.FindWithTag("Player") == null)
            {
                // Generate player
                Instantiate(g_variables.PlayerBody);
                // Move to gen pos
                g_variables.PlayerBody.transform.position = g_variables.PlayerGenPos.transform.position;

                // Cnt1++
                g_variables.Cnt1++;
            }
        }
    }
}