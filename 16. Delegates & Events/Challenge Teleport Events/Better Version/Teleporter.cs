using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onButton += StartTeleport;
    }

    public void StartTeleport(Vector3 pos)
    {
        transform.position = pos;
    }

}
