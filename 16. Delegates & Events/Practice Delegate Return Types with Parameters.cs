using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public Func<int, int, int> onCalculateSum;

    public void Start()
    {
        //onCalculateSum = (a, b) => a + b;

        onCalculateSum = (a, b) =>
        {
            return a + b;
        };

        var total = onCalculateSum(5, 5);

        Debug.Log(total);
    }


}
