using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public GameObject[] objectToSpawn = new GameObject[10];

    // Start is called before the first frame update
    void Start()
    {
        objectToSpawn[0].name = "John";
        enemiesToSpawn[0].name = "Kyle";
    }

}
