using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Action onGetName;

    private void Start()
    {
        onGetName = () =>
        {
            Debug.Log("Name: " + gameObject.name);
            Debug.Log("It's a nice day out!");
        };

        //code logic
        //more code logic

        onGetName();
    }

}
