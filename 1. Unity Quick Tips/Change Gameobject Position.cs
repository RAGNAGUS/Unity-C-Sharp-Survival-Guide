using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //asign startPosition
        startPosition = new Vector3(0, 0, 0);

        //grab the current pos = (asign) new position
        transform.position = new Vector3(0, 0, 0);

        //grab the current pos = (asign) new position in Unity
        transform.position = startPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}