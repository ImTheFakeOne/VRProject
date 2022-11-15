using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load("Car") as GameObject;
        for (int i=0; i<10; i++)
        {
            GameObject go = Instantiate(prefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
