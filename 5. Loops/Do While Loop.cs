using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        do
        {
            Debug.Log(i);
            i++;

        } while (i < 50);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
