using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToGreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onClick += ChangeColor;
    }

    public void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void OnDisable()
    {
        Main.onClick -= ChangeColor;
    }
}
