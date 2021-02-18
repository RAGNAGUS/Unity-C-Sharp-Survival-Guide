using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;
    public string name;
    public string description;
}

public class Player : MonoBehaviour
{
    public int searchItem;
    public Item[] myItems;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in myItems)
        {
            Debug.Log(item.name);
        }

        if (searchItem == myItems[searchItem].itemID)
        {
            Debug.Log("Your selected item is " + myItems[searchItem].name);
        }
        else
        {
            Debug.Log("Can't find this item");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomID = Random.Range(0, myItems.Length);

            Debug.Log(myItems[randomID].name);
        }
    }
}

