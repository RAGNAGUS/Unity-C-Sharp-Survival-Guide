﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            if (value == true)
            {
                Debug.Log("The game is over!");
            }
            isGameOver = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(IsGameOver);
            IsGameOver = true;

        }
    }
}
