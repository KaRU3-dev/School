using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidingObjectGenerater : MonoBehaviour
{
    // Components
    [Header("Components")]
    [SerializeField] private float DeltaT;
    [SerializeField] private float GenDistance;
    [SerializeField] private GameObject ParentObject;

    // Default position and object
    [Header("Default pos and obj")]
    [SerializeField] private int DefaultGenPos;
    [SerializeField] private int DefaultObj;

    // Wood
    [Header("Wood")]
    [SerializeField] private GameObject WoodShort;
    [SerializeField] private GameObject WoodLong;
    [Header("Turtle")]
    [SerializeField] private GameObject TurtleLeftToRight;
    [SerializeField] private GameObject TurtleRightToLeft;

    // Generatable position
    [Header("Generatable position")]
    [SerializeField] private GameObject GeneratePos1;
    [SerializeField] private GameObject GeneratePos2;
    [SerializeField] private GameObject GeneratePos3;
    [SerializeField] private GameObject GeneratePos4;

    // Generate global postion
    [Header("Generate global position (Get only)")]
    [SerializeField] private Vector3 GeneraterPos1Vector3;
    [SerializeField] private Vector3 GeneraterPos2Vector3;
    [SerializeField] private Vector3 GeneraterPos3Vector3;
    [SerializeField] private Vector3 GeneraterPos4Vector3;

    private void Start()
    {
        ShowGeneraterPosition(GeneratePos1, GeneratePos2, GeneratePos3, GeneratePos4);
    }


    /// <summary>
    /// Show generater position to inspector
    /// </summary>
    /// <param name="Pos1">GameObject</param>
    /// <param name="Pos2">GameObject</param>
    /// <param name="Pos3">GameObject</param>
    private void ShowGeneraterPosition(GameObject Pos1, GameObject Pos2, GameObject Pos3, GameObject Pos4)
    {
        GeneraterPos1Vector3 = Pos1.transform.position;
        GeneraterPos2Vector3 = Pos2.transform.position;
        GeneraterPos3Vector3 = Pos3.transform.position;
        GeneraterPos4Vector3 = Pos4.transform.position;
    }

    public void Generator()
    {
        GameObject selectedObject;

        int SpwanPoint = RandomIntGen();

        // Wood or Turtle
        int objNum = UnityEngine.Random.Range(1, 3);
        // If wood
        if (objNum == 1)
        {
            selectedObject = Instantiate(WoodSelector());
        }
        // else if turtle
        else if (objNum == 2)
        {
            selectedObject = Instantiate(TurtleSelect());
        }
        // else #wood
        else
        {
            selectedObject = Instantiate(WoodSelector());
        }

        // Select generate position
        GameObject pos = PositionSelect(selectedObject);

        // Set position
        SetSelectedObjPosition(selectedObject, pos);

    }

    /// <summary>
    /// Generate random int
    /// </summary>
    /// <returns>int 1 to 3</returns>
    private int RandomIntGen()
    {
        int tmp = UnityEngine.Random.Range(1, 4);
        return tmp;
    }
    /// <summary>
    /// Wood gam object selector
    /// </summary>
    /// <returns>GameObject WoodShort/WoodLong</returns>
    private GameObject WoodSelector()
    {
        int tmp = UnityEngine.Random.Range(1, 3);

        if (tmp == 1)
        {
            return TurtleLeftToRight;
        }
        else if (tmp == 2)
        {
            return TurtleRightToLeft;
        }
        else
        {
            return TurtleLeftToRight;
        }
    }

    private GameObject TurtleSelect()
    {
        int tmp = UnityEngine.Random.Range(1, 3);

        if (tmp == 1)
        {
            return WoodShort;
        }
        else if (tmp == 2)
        {
            return WoodLong;
        }
        else
        {
            return WoodShort;
        }
    }

    /// <summary>
    /// Generate position number
    /// </summary>
    /// <param name="obj">GameObject</param>
    /// <returns>int UnityEngine.Random</returns>
    private GameObject PositionSelect(GameObject obj)
    {

        if (obj.tag == "ShortWood")
        {
            int tmp = UnityEngine.Random.Range(1, 5);
            if (tmp == 1)
            {
                return GeneratePos1;
            }
            else if (tmp == 2)
            {
                return GeneratePos2;
            }
            else if (tmp == 3)
            {
                return GeneratePos3;
            }
            else if (tmp == 4)
            {
                return GeneratePos4;
            }
            else
            {
                return GeneratePos1;
            }
        }
        else if (obj.tag == "LongWood")
        {
            int tmp = UnityEngine.Random.Range(1, 5);
            if (tmp == 1)
            {
                return GeneratePos1;
            }
            else if (tmp == 2)
            {
                return GeneratePos2;
            }
            else if (tmp == 3)
            {
                return GeneratePos3;
            }
            else if (tmp == 4)
            {
                return GeneratePos4;
            }
            else
            {
                return GeneratePos1;
            }
        }
        else if (obj.tag == "GoRightTurtle")
        {
            int tmp = UnityEngine.Random.Range(1, 3);
            if (tmp == 1)
            {
                return GeneratePos2;
            }
            else if (tmp == 2)
            {
                return GeneratePos4;
            }
            else
            {
                return GeneratePos2;
            }
        }
        else if (obj.tag == "GoLeftTurtle")
        {
            int tmp = UnityEngine.Random.Range(1, 3);
            if (tmp == 1)
            {
                return GeneratePos1;
            }
            else if (tmp == 2)
            {
                return GeneratePos3;
            }
            else
            {
                return GeneratePos1;
            }
        }
        else
        {
            return GeneratePos1;
        }
    }

    private void SetSelectedObjPosition(GameObject obj, GameObject pos)
    {
        obj.transform.position = new Vector3(pos.transform.position.x, pos.transform.position.y + 0.5f, pos.transform.position.z);
    }
}
