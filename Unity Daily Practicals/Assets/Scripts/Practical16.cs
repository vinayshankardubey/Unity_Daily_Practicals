using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practical16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("waitForASecond");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waitForASecond(){
    yield return new WaitForSeconds(5f);

    print("Coroutines Done");
    }
}
