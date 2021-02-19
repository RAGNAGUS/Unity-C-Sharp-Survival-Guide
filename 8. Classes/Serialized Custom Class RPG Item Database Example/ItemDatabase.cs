using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    [SerializeField]
    Item sword;
    Item hammer;
    Item bread;

    // Start is called before the first frame update
    void Start()
    {
        sword = new Item();
        sword.name = "Sword";
        sword.id = 1;
        sword.description = "This is a sword!";

        hammer = new Item("Hammer", 2, "This is a hammer!");

        bread = CreateItem("Bread", 3, "I can eat this!");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Item CreateItem(string name, int id, string description)
    {
        var Item = new Item(name, id, description);
        return Item;
    }
}
