﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;

    private void Start()
    {
        onColorChange = UpdateColor;
        onColorChange(Color.green);

        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;
        onComplete();

        if (onComplete != null)
        {
            onComplete -= Task3;
        }
    }

    public void UpdateColor(Color newColor)
    {
        Debug.Log("Changing color to: " + newColor.ToString());
    }

    public void Task()
    {
        Debug.Log("Task Finished");
    }

    public void Task2()
    {
        Debug.Log("Task 2 Finished");
    }

    public void Task3()
    {
        Debug.Log("Task 3 Finished");
    }


}
