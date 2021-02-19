using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item2
{
    public string name;
    public int itemID;

    public Item2(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

public class Item
{
    public string name;
    public int itemID;
    public Item(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

public class Struct : MonoBehaviour
{
    Item sword = new Item("Sword", 1);
    Item2 bread;

    // Start is called before the first frame update
    void Start()
    {
        bread.name = "Bread";
        bread.itemID = 2;

        Debug.Log("Sword Current Name: " + sword.name);
        ChangeValue(sword);
        Debug.Log("Sword Current Name (After Method): " + sword.name);

        Debug.Log("Current bread name: " + bread.name);
        ChangeValue(bread);
        Debug.Log("Current bread name (After Method): " + bread.name);

    }

    void ChangeValue(Item2 structItem)
    {
        structItem.name = "Fresh Bread";
    }

    void ChangeValue(Item classItem)
    {
        classItem.name = "Master Sword";
    }
}
