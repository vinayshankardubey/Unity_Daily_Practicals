using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical5 : MonoBehaviour
{
    float growthRate = 0.0005f;
    float groundLevel = 0;
    float speed = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if( transform.position.y > groundLevel){

            transform.Translate(0, -speed, 0);

        } else{

            transform.localScale = new Vector3(transform.localScale.x + growthRate, transform.localScale.y + growthRate, transform.localScale.z + growthRate);


        }

    }
}
