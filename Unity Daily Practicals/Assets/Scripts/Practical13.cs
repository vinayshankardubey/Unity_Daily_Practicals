using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical13 : MonoBehaviour
{

    public Color myColor = Color.red;
    public float myBounciness = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
this.gameObject.AddComponent<Rigidbody>();
PhysicMaterial material = new PhysicMaterial();
material.bounciness = myBounciness;
this.GetComponent<Collider>().material = material;
this.GetComponent<Renderer>().material.color = myColor;
this.GetComponent<Renderer>().material.color = myColor;
        
    }

    // Update is called once per frame
    void Update()
    {
        




    }
}
