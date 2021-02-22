using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void OnButton(int x, int y, int z);
    public static event OnButton onButton;

    public int x, y, z;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onButton != null)
            {
                onButton(x, y, z);
            }
        }
    }
}
