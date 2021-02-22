using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void OnButton(Vector3 pos);
    public static event OnButton onButton;

    public Vector3 posToTeleport = new Vector3(5, 2, 0);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onButton != null)
            {
                onButton(posToTeleport);
            }
        }
    }
}
