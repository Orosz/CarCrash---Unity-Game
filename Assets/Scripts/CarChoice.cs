using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    //1=Red, 2=Blue
    public GameObject RedBody;
    public GameObject BlueBody;
    //public GameObject GreyBody;
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 2)
        {
            RedBody.SetActive(true);
        }

        if (CarImport == 1)
        {
            BlueBody.SetActive(true);
        }
    }
}
