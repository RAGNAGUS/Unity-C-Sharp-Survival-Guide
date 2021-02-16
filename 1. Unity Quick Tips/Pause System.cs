using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Press Space to pause the game
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //Pause the game
            Time.timeScale = 0;
        }

        //Press R to resume the game
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Resume the game
            Time.timeScale = 1;
        }

        //Press S to slowdown the game
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            //Slow motion
            Time.timeScale = 0.25f;
        }

    }
}