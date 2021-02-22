using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //public delegate int CharacterLength(string text);

    public Func<string, int> CharacterLength;

    private void Start()
    {
        CharacterLength = (name) => name.Length; //Lambda Expression

        int count = CharacterLength("Jonathan");

        Debug.Log("Count: " + count);
    }

    /*int GetCharacters(string name)
    {
        return name.Length;
    }*/
}
