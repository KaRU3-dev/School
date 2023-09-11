using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace FloggerGame.Generators
{
    public class car_support
    {
        /// <summary>
        /// Generate random amount 1 to {max}
        /// </summary>
        /// <param name="max">int max</param>
        /// <returns>int result</returns>
        public static int Selector(int max)
        {
            int result = UnityEngine.Random.Range(1, max);

            return result;
        }
    }
}

