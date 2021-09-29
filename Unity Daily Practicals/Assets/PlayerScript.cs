using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool getKey = Input.GetKey(KeyCode.Space);

        bool getKeyDown = Input.GetKeyDown(KeyCode.Space);

        bool getKeyUp = Input.GetKeyUp(KeyCode.Space);

        if (getKey)
        {
            Debug.Log("Get Key Called");
            textObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Get Key Called";
        }

        if (getKeyDown)
        {
            Debug.Log("Get Key Down Called");
            textObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Get Key Down Called";
        }

        if (getKeyUp)
        {
            Debug.Log("Get Key Up Called");
            textObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Get Key Down Called";
        }
    }
}
