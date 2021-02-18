using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.red);
        }
    }

    private void ChangeColor(GameObject obj, Color selectedColor)
    {
        cube.GetComponent<MeshRenderer>().material.color = selectedColor;
    }

}

