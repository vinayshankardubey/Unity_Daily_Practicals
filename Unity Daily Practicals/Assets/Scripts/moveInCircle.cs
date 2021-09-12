using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveInCircle : MonoBehaviour
{

    float radius = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(radius * Mathf.Sin(Time.fixedTime), radius * Mathf.Cos(Time.fixedTime), 0
    );
    }
}
