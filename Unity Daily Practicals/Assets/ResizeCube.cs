using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeCube : MonoBehaviour
{

    public float objScaleX = 2.0f;
    public float objScaleY = 0.2f;
    public float objScaleZ = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.localScale = new Vector3(objScaleX, objScaleY, objScaleZ)
;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
