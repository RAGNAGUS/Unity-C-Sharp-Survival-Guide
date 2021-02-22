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
        CharacterLength = GetCharacters;

        int count = CharacterLength("Jonathan");
        Debug.Log(count);
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}
