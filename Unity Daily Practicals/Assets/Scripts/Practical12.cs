using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical12 : MonoBehaviour
{

    public Color myColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
this.gameObject.AddComponent<Rigidbody>();
PhysicMaterial material = new PhysicMaterial();
material.bounciness = 0.5f;
this.GetComponent<Collider>().material = material;
this.GetComponent<Renderer>().material.color = myColor;
this.GetComponent<Renderer>().material.color = myColor;
        
    }

    // Update is called once per frame
    void Update()
    {
        




    }
}
