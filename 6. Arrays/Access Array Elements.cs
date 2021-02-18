using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string[] names;
    public string[] items = new string[10];
    public int[] ages = new int[] { 5, 10, 15, 20, 25, 30 };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(names[0]); //have to assign in Unity
        Debug.Log(ages[3]);
        Debug.Log(items[0]); //have to assign in Unity
    }
    // Update is called once per frame
    void Update()
    {

    }
}

