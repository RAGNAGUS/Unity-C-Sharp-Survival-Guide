using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats 
{
    public string name;
    public float fireRate;
    public int ammoCount;

    //Constructor
    public WeaponStats(string name, float fireRate, int ammoCount) 
    {
        //Initialize things here
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}

public class Player : MonoBehaviour
{
    //Create an Object
    public WeaponStats blaster;
    public WeaponStats rockets;

    // Start is called before the first frame update
    void Start()
    {
        blaster = new WeaponStats("Blaster", 0.25f, 50);

    }
    // Update is called once per frame
    void Update()
    {

    }


}

