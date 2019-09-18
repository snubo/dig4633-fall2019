using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    float Cube =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cube = Cube + Time.deltaTime;
        gameObject.transform.Translate(0, Time.deltaTime, 0);
    }
}
