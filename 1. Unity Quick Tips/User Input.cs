using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if space key pressed down
        //print a message
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("Space Key");
        }

        //if e key held down
        //print a message
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding E");
        }

        //if f key is lifted up
        //print a message
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F lifted up");
        }
    }
}