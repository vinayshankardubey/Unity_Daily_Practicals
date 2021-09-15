using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical10 : MonoBehaviour
{
    // Start is called before the first frame update
    

    void Start()
    {
    GameObject gameObject;
    
    gameObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
    gameObject.transform.position = new Vector3(0,0,0);
    gameObject.AddComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
