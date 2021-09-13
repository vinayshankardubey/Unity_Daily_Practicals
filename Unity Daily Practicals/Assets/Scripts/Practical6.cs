using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject oP;
        
        for(int i = 1; i <= 9; i++){

            oP = GameObject.CreatePrimitive(PrimitiveType.Cube);

            oP.transform.position = new Vector3(-i, i + 5, 0);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
