using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{
    int doorCount;
    string colorOfCar;
    int id;
    string liscencePlate;
    int horsePower;
    bool isElectric;
    float maxSpeed;


    Car(int doorCount, string colorOfCar, int id, string liscencePlate, int horsePower, bool isElectric, float maxSpeed)
    {
        this.doorCount = doorCount;
        this.colorOfCar = colorOfCar;
        this.id = id;
        this.liscencePlate = liscencePlate;
        this.horsePower = horsePower;
        this.isElectric = isElectric;
        this.maxSpeed = maxSpeed;
    }

    string Drive()
    {
        return "Driving";
    }

    void StartEngine()
    {
        Debug.Log("Engine Starting");
    }

    void Honk()
    {
        Debug.Log("BEEP BEEP");
    }

    private void Start()
    {
        Car bmw = new Car(5, "BLACK", 1, "SK1919BL", 150, false, 210.5f);
        string toPrint = bmw.Drive();
        bmw.StartEngine();
    }
}
