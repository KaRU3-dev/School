using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Generator : MonoBehaviour
{

    // Variables
    [Header("Variables")]
    [SerializeField] private float Speed;
    [SerializeField] private float DeltaT;
    [SerializeField] private float GenDistance;

    [Header("Liver gen pos left")]
    [SerializeField] private GameObject GenPosLeftTop;
    [SerializeField] private GameObject GenPosLeftBottom;

    [Header("Liver gen pos right")]
    [SerializeField] private GameObject GenPosRightTop;
    [SerializeField] private GameObject GenPosRightBottom;

    [Header("Road gen pos left")]
    [SerializeField] private GameObject GenPosLeftRow1;

    [Header("Road gen pos right")]
    [SerializeField] private GameObject GenPosRightRow1;
    [SerializeField] private GameObject GenPosRightRow2;

    [Header("Game object")]
    [SerializeField] private GameObject WoodLongToLeft;
    [SerializeField] private GameObject WoodLongToRight;
    [SerializeField] private GameObject WoodShortToLeft;
    [SerializeField] private GameObject WoodShortToRight;
    [SerializeField] private GameObject ClabLongToLeft;
    [SerializeField] private GameObject ClabLongToRight;
    [SerializeField] private GameObject ClabShortToRight;
    [SerializeField] private GameObject ClabShortToLeft;
    [SerializeField] private GameObject CarToLeft1;
    [SerializeField] private GameObject CarToLeft2;
    [SerializeField] private GameObject CarToLeft3;
    [SerializeField] private GameObject CarToRight1;
    [SerializeField] private GameObject CarToRight2;

    private void Update()
    {
        // Random
        System.Random rnd = new();

        // Timer
        DeltaT += Time.deltaTime;

        if (DeltaT == GenDistance)
        {
            // Gen liver left side 1
            GameObject obj1 = Instantiate(LiverLeftObjectSelecter(WoodLongToRight, WoodShortToRight, ClabLongToRight, ClabShortToRight, rnd));
            obj1.transform.position = GenPosLeftTop.transform.position;

            // Gen liver left side 2
            GameObject obj2 = Instantiate(LiverLeftObjectSelecter(WoodLongToRight, WoodShortToRight, ClabLongToRight, ClabShortToLeft, rnd));
            obj2.transform.position = GenPosLeftBottom.transform.position;

            // Gen liver right side 1
            GameObject obj3 = Instantiate(LiverRightObjectSelecter(WoodLongToLeft, WoodShortToLeft, ClabLongToLeft, ClabShortToLeft, rnd));
            obj2.transform.position = GenPosLeftBottom.transform.position;

            // Gen liver right side 2
            GameObject obj4 = Instantiate(LiverRightObjectSelecter(WoodLongToLeft, WoodShortToLeft, ClabLongToLeft, ClabShortToRight, rnd));
            obj2.transform.position = GenPosLeftBottom.transform.position;

            // Gen load left side
            GameObject obj5 = Instantiate(LoadLeftObjectSelecter(CarToRight1, CarToRight2, rnd));
            obj5.transform.position = GenPosLeftRow1.transform.position;

            // gen load right side 1
            GameObject obj6 = Instantiate(LoadRightObjectSelecter(CarToLeft1, CarToLeft2, CarToLeft3, rnd));
            obj6.transform.position = GenPosRightRow1.transform.position;

            // Gen load right side 2
            GameObject obj7 = Instantiate(LoadRightObjectSelecter(CarToLeft1, CarToLeft2, CarToLeft3, rnd));
            obj7.transform.position = GenPosRightRow2.transform.position;

            // Reset DeltaT
            DeltaT = 0;
        }
    }

    private GameObject LiverLeftObjectSelecter(GameObject item1, GameObject item2, GameObject item3, GameObject item4, System.Random rnd)
    {

        // Generate random
        int objInt = rnd.Next(1, 4);

        // Generate object
        if (objInt == 1)
        {
            return item1;
        }
        else if (objInt == 2)
        {
            return item2;
        }
        else if (objInt == 3)
        {
            return item3;
        }
        else if (objInt == 4)
        {
            return item4;
        }
        else
        {
            return null;
        }

    }
    private GameObject LiverRightObjectSelecter(GameObject item1, GameObject item2, GameObject item3, GameObject item4, System.Random rnd)
    {

        // Generate random
        int objInt = rnd.Next(1, 2);

        // Generate object
        if (objInt == 1)
        {
            return item1;
        }
        else if (objInt == 2)
        {
            return item2;
        }
        else if (objInt == 3)
        {
            return item3;
        }
        else if (objInt == 4)
        {
            return item4;
        }
        else
        {
            return null;
        }

    }

    private GameObject LoadLeftObjectSelecter(GameObject item1, GameObject item2, System.Random rnd)
    {
        // Generate random int
        int objInt = rnd.Next(1, 2);

        // Generate object
        if (objInt == 1)
        {
            return item1;
        }
        else if (objInt == 2)
        {
            return item2;
        }
        else
        {
            return null;
        }
    }
    private GameObject LoadRightObjectSelecter(GameObject item1, GameObject item2, GameObject item3, System.Random rnd)
    {
        // Generate random int
        int objInt = rnd.Next(1, 2);

        // Generate object
        if (objInt == 1)
        {
            return item1;
        }
        else if (objInt == 2)
        {
            return item2;
        }
        else if (objInt == 3)
        {
            return item3;
        }
        else
        {
            return null;
        }
    }
}
