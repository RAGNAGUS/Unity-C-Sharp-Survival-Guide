using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumeable
    }

    public ItemType itemType;

    public void Action()
    {
        switch (itemType)
        {
            case ItemType.Weapon:
                Debug.Log("This is a " + ItemType.Weapon + " : " + name);
                break;
            case ItemType.Consumeable:
                Debug.Log("This is a " + ItemType.Consumeable + " : " + name);
                break;
            default:
                break;
        }
    }
}
