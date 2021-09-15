using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical9 : MonoBehaviour
{
    // Start is called before the first frame update
            GameObject[] ap = new GameObject[10];


    void Start()
    {
        

        for( int i = 0; i <= 9; i++){
            ap[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
             
             ap[i].transform.position = new Vector3(0 + i, 0 + i, 0);
        }

    

    }

    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i <= 9; i++){

            ap[i].GetComponent<Renderer>().material.color = new Color(Random.Range(0.1f, 1.0f),Random.Range(0.1f, 1.0f),Random.Range(0.1f, 1.0f));
           
        }

    }
}
