using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToBlue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onClick += ChangeColor;
    }

    public void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    private void OnDisable()
    {
        Main.onClick -= ChangeColor;
    }
}
