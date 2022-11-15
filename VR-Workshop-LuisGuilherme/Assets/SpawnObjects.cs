using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cars = Resources.Load("Car") as GameObject;
        for (int i=0; i<5; i++)
        {
            GameObject go = Instantiate(cars);
        }

        GameObject predestrians = Resources.Load("Pedestrian") as GameObject;
        for (int i=0; i<9; i++)
        {
            GameObject go = Instantiate(predestrians);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
