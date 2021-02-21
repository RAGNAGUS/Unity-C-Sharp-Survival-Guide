using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemDatabase = new List<Item>();

    public void AddItem(int itemID, Player player)
    {
        foreach (var item in itemDatabase)
        {
            if (item.id == itemID)
            {
                //Check for available inventory slots
                Debug.Log("We have a match!");
                player.inventory[0] = item;
                return;
            }
        }
        Debug.Log("Item does not exist!");
    }

    public void RemoveItem(int itemID, Player player)
    {
        foreach (var item in itemDatabase)
        {
            if (item.id == itemID)
            {
                Debug.Log("We have a match!");
                player.inventory[0] = null;
            }
        }
    }
}
