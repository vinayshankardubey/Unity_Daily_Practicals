using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical11 : MonoBehaviour
{
    // Start is called before the first frame update
  new GameObject gameObject;

    void Start()
    {
        
        gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        gameObject.transform.position = new Vector3(0,5,0);
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        gameObject.transform.localScale = new Vector3(1, 1, 1);

        gameObject.AddComponent<Rigidbody>();

        PhysicMaterial material = new PhysicMaterial();

        material.bounciness = 1;

        gameObject.GetComponent<Collider>().material = material;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
