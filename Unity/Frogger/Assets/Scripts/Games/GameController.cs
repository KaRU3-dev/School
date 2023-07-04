using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameComponents Components;

    // Start is called before the first frame update
    void Start()
    {
        Components = gameObject.GetComponent<GameComponents>();
    }

    // Update is called once per frame
    void Update()
    {
        MapObjectGeneretion();
    }

    private void MapObjectGeneretion()
    {
        Components.CarDeltaT += Time.deltaTime;

        if (Components.CarDeltaT > Components.CarGenTiming)
        {
            Components.CarDeltaT = 0;
            Components.CarGenerator.Generator();
        }

        Components.RidingObjectDeltaT += Time.deltaTime;
        if (Components.RidingObjectDeltaT > Components.RidingObjectGenTiming)
        {
            Components.RidingObjectDeltaT = 0;
            Components.RidingObjectGenerator.Generator();
        }
    }
}
