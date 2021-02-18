using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        transform.position = RandomPosition();
    }
    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 RandomPosition() 
    {
        Vector3 pos = new Vector3(Random.value, Random.value, Random.value);
        return pos;
    }

}

