using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GameObject[] gO = new GameObject[10];
        
        for(int i = 0 ; i < 10; i++){

            gO[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);

            gO[i].transform.position = new Vector3(i + 1, i + 1, 0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
