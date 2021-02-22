using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /*public Dictionary<string, int> people = new Dictionary<string, int>();

    private void Start()
    {
        people.Add("Jon", 26);
        people.Add("James", 58);
        people.Add("Rachel", 32);
        people.Add("Jack", 35);

        int rachelAge = people["Rachel"];
        Debug.Log(rachelAge);
    }*/

    public Dictionary<int, string> books = new Dictionary<int, string>();

    private void Start()
    {
        books.Add(0, "The Ultimate Guide to Game Development with Unity");
        books.Add(1, "The Unity C# Survival Guide");

        foreach (KeyValuePair<int, string> book in books)
        {
            Debug.Log("Book: " + book.Value);
        }

        foreach (string book in books.Values)
        {
            Debug.Log(book);
        }
    }
}
