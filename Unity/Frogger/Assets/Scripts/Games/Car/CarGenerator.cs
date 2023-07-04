using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenerator : MonoBehaviour
{
    // Components
    [Header("Components")]
    [SerializeField] private float DeltaT;
    [SerializeField] private float GenDistance;
    [SerializeField] private GameObject ParentObject;

    // Default is Car1 and Pos1
    [Header("Default")]
    [SerializeField] private int DefaultPos;
    [SerializeField] private int DefaultCar;

    // Car 1 ~ 4: from right to left
    // Car 4 and 5: from left to right
    [Header("Car GameObject")]
    [SerializeField] private GameObject Car1;
    [SerializeField] private GameObject Car2;
    [SerializeField] private GameObject Car3;
    [SerializeField] private GameObject Car4;
    [SerializeField] private GameObject Car5;

    // These are empty object
    [Header("Car Generative Position")]
    [SerializeField] private GameObject GeneratorPos1;
    [SerializeField] private GameObject GeneratorPos2;
    [SerializeField] private GameObject GeneratorPos3;

    // Do not change these variables
    [Header("Generator Position (Get Only)")]
    [SerializeField] private Vector3 VectorPos1;
    [SerializeField] private Vector3 VectorPos2;
    [SerializeField] private Vector3 VectorPos3;

    private void Start()
    {
        ShowGeneratorPosition();
    }

    /// <summary>
    /// Show generator position
    /// </summary>
    public void ShowGeneratorPosition()
    {
        VectorPos1 = GeneratorPos1.transform.position;
        VectorPos2 = GeneratorPos2.transform.position;
        VectorPos3 = GeneratorPos3.transform.position;
    }

    /// <summary>
    /// Generator for random car object
    /// <para>This method can generate</para>
    /// </summary>
    public void Generator()
    {
        GameObject SelectedCar;

        int SelectedPos = SelectGenPosition();

        if (SelectedPos == 1 || SelectedPos == 2)
        {
            SelectedCar = SelectCarGameObject();
            SelectedCar.transform.parent = ParentObject.transform;
            SetPositionForCar(SelectedPos, SelectedCar);
        }
        else // SelectedPos == 3 and other
        {
            SelectedCar = Instantiate(Car5);
            SelectedCar.transform.parent = ParentObject.transform;
            SetPositionForCar(SelectedPos, SelectedCar);
        }
    }

    private int SelectGenPosition()
    {
        int pos = UnityEngine.Random.Range(1, 4);
        // Debug.Log(pos);
        return pos;
    }
    private GameObject SelectCarGameObject()
    {
        int car = UnityEngine.Random.Range(1, 5);
        GameObject selectedCar = Instantiate(SelectCar(car));
        return selectedCar;
    }

    private void SetPositionForCar(int pos, GameObject car)
    {
        // If pos = 1, generate to position 1
        if (pos == 1)
        {
            car.transform.position = new Vector3(GeneratorPos1.transform.position.x, GeneratorPos1.transform.position.y + 0.5f, GeneratorPos1.transform.position.z);
        }
        // If pos = 2, generate to position 2
        else if (pos == 2)
        {
            car.transform.position = new Vector3(GeneratorPos2.transform.position.x, GeneratorPos2.transform.position.y + 0.5f, GeneratorPos2.transform.position.z);
        }
        // If pos = 3, generate to position 3
        else if (pos == 3)
        {
            car.transform.position = new Vector3(GeneratorPos3.transform.position.x, GeneratorPos3.transform.position.y + 0.5f, GeneratorPos3.transform.position.z);
        }
        // Can't find between 1 ~3, generate to position 1
        else
        {
            car.transform.position = new Vector3(GeneratorPos1.transform.position.x, GeneratorPos1.transform.position.y + 0.5f, GeneratorPos1.transform.position.z);
        }
    }

    /// <summary>
    /// This method can return Car1 ~ Car4 (Right to Left)
    /// </summary>
    /// <param name="car"></param>
    /// <returns>GameObject PreFab</returns>
    private GameObject SelectCar(int car)
    {
        if (car == 1)
        {
            return Car1;
        }
        else if (car == 2)
        {
            return Car2;
        }
        else if (car == 3)
        {
            return Car3;
        }
        else if (car == 4)
        {
            return Car4;
        }
        else
        {
            return Car1;
        }
    }
}
