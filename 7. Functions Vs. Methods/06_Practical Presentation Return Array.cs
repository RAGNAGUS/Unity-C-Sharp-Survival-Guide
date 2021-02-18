﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        players = GetAllPlayers();

        foreach (var item in GetAllPlayers())
        {
            Debug.Log(item);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        foreach (var player in allPlayers)
        {
            player.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return allPlayers;
    }
}

