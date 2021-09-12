using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growGameObject : MonoBehaviour
{
    float growthRate = 0.0005f;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = new Vector3(transform.localScale.x + growthRate, transform.localScale.y + growthRate, transform.localScale.z + growthRate);
        
    }
}
