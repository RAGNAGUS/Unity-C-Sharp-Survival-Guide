using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cube;
    private int _colorSelect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _colorSelect = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _colorSelect = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _colorSelect = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _colorSelect = 4;
        }

        switch (_colorSelect)
        {
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 4:
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                Debug.Log("Invalid Selection");
                break;
        }
    }
}
