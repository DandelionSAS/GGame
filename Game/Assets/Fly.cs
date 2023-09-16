using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameObject fly;
    void Start()
    {
        InvokeRepeating("Spawn", 2, 2);
        print("gggg");
    }
    
    
    void Spawn()
    {
        float x = Random.Range(-9.0f, 9.0f);
        float z = Random.Range(-4.0f, 4.0f);
        fly.transform.position = new Vector2(x, z);
    }
    
    
}
