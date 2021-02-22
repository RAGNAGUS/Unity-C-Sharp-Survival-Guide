using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public void Start()
    {
        StartCoroutine(MyRoutine(() =>
        {
            Debug.Log("The Routine has finished!");
        }));
    }

    public IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(5.0f);

        if (onComplete != null)
        {
            onComplete();
        }
    }

}
