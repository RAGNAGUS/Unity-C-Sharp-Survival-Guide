using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{

    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    private void Start()
    {
        Item sword = new Item();
        sword.name = "Sword";
        sword.id = 0;

        Item bread = new Item();
        bread.name = "Bread";
        bread.id = 1;

        Item cape = new Item();
        cape.name = "Cape";
        cape.id = 2;

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        /*foreach (KeyValuePair<int, Item> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Value: " + item.Value.name);
        }*/

        /*foreach (int item in itemDictionary.Keys)
        {
            Debug.Log("Key: " + item);
        }*/

        /*foreach (Item item in itemDictionary.Values)
        {
            Debug.Log("Item Name: " + item.name);
        }*/

        if (itemDictionary.ContainsKey(0))
        {
            Debug.Log("You found the key!");
            var randomItem = itemDictionary[0];
        }
        else
        {
            Debug.Log("Key does not exist!");
        }
    }
}
