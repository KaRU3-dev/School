using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenerator : MonoBehaviour
{
    [Header("�f�t�H���g")]
    [SerializeField] private int DefaultPos;
    [SerializeField] private int DefaultCar;

    [Header("�Ԑ����|�W�V����")]
    [SerializeField] private GameObject Car1;
    [SerializeField] private GameObject Car2;
    [SerializeField] private GameObject Car3;
    [SerializeField] private GameObject Car4;
    [SerializeField] private GameObject Car5;

    [Header("�Ԑ����|�W�V����")]
    [SerializeField] private GameObject GeneratorPos1;
    [SerializeField] private GameObject GeneratorPos2;
    [SerializeField] private GameObject GeneratorPos3;

    System.Random rnd = new System.Random();

    public int CalucurateCarGenPosition()
    {
        int ReturnInt = rnd.Next(1, 3);

        return ReturnInt;
    }

    public int SubmitCar()
    {
        int GenPos = CalucurateCarGenPosition();

        if (GenPos == 1 || GenPos == 2)
        {
            // �E���獶�ɍs���Ԃ̑I��
            int carSubmit = rnd.Next(1, 4);

            return carSubmit;
        }
        else if (GenPos == 3)
        {
            // ������E�ɍs���Ԃ̑I��
            int carSubmit = rnd.Next(1, 4);

            return carSubmit;
        }
        else
        {
            return DefaultCar;
        }
    }

    public void GenerateCar(int pos, int car)
    {

    }
}
