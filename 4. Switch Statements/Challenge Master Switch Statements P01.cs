using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int point;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            point = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            point = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            point = 0;
        }

        switch (point)
        {
            case 50:
                Debug.Log("Points are 50!");
                break;
            case 100:
                Debug.Log("Points are 100!");
                break;
            default:
                Debug.Log("You need 50 or 100 points to recieve a message");
                break;
        }
    }
}
