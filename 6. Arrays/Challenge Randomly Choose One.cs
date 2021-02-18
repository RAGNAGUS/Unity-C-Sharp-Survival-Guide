using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string[] names;
    public int[] ages;
    public string[] cars;
    public int randomID;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomID = Random.Range(0, names.Length);

            Debug.Log("Name: " + names[randomID] + "Age: " + ages[randomID] + "Car model: " + cars[randomID]);
        }
    }
}

