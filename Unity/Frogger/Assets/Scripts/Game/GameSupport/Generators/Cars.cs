using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FloggerGame.Generators
{
    public class Cars : MonoBehaviour
    {
        // Car objects
        [Header("Left to Right")]
        [Tooltip("Left to Right")][SerializeField] GameObject car1;
        [Tooltip("Left to Right")][SerializeField] GameObject car2;
        [Header("Right to Left")]
        [Tooltip("Right to Left")][SerializeField] GameObject car3;
        [Tooltip("Right to Left")][SerializeField] GameObject car4;
        [Tooltip("Right to Left")][SerializeField] GameObject car5;

        // Car generate pos
        [Header("Car generate pos")]
        [Tooltip("Left upper")][SerializeField] GameObject pos1;
        [Tooltip("Left lower")][SerializeField] GameObject pos2;
        [Tooltip("Right middle")][SerializeField] GameObject pos3;

        public void Generator()
        {
            int selectPos = car_support.Selector(4);

            int carSelector = 0;

            switch (selectPos)
            {
                case 1:
                    carSelector = car_support.Selector(3);
                    if (carSelector == 1)
                    {
                        GameObject genObj = Instantiate(car1);
                        genObj.transform.position = pos1.transform.position;
                    }
                    else if (carSelector == 2)
                    {
                        GameObject genObj = Instantiate(car2);
                        genObj.transform.position = pos1.transform.position;
                    }
                    else if (carSelector == 3)
                    {
                        GameObject genObj = Instantiate(car3);
                        genObj.transform.position = pos1.transform.position;
                    }
                    else
                    {
                        GameObject genObj = Instantiate(car1);
                        genObj.transform.position = pos1.transform.position;
                    }
                    break;
                case 2:
                    carSelector = car_support.Selector(3);
                    if (carSelector == 1)
                    {
                        GameObject genObj = Instantiate(car1);
                        genObj.transform.position = pos2.transform.position;
                    }
                    else if (carSelector == 2)
                    {
                        GameObject genObj = Instantiate(car2);
                        genObj.transform.position = pos2.transform.position;
                    }
                    else if (carSelector == 3)
                    {
                        GameObject genObj = Instantiate(car3);
                        genObj.transform.position = pos2.transform.position;
                    }
                    else
                    {
                        GameObject genObj = Instantiate(car1);
                        genObj.transform.position = pos2.transform.position;
                    }
                    break;
                case 3:
                    carSelector = car_support.Selector(4);
                    if (carSelector == 1)
                    {
                        GameObject genObj = Instantiate(car1);
                        genObj.transform.position = pos3.transform.position;
                    }
                    else if (carSelector == 2)
                    {
                        GameObject genObj = Instantiate(car2);
                        genObj.transform.position = pos3.transform.position;
                    }
                    else
                    {
                        GameObject genObj = Instantiate(car1);
                        genObj.transform.position = pos3.transform.position;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
