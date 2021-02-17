using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 5;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 5;
        }

        if (speed > 20)
        {
            Debug.Log("Slow Down!, now your speed is " + speed);
        }
        else if (speed == 0) 
        {
            Debug.Log("Speed Up!, now your speed is " + speed);
        }

        if (speed < 0) 
        {
            speed = 0;
        }
    }
}
