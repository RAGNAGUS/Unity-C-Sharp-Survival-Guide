using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeReviewMasterVariablesPart01 : MonoBehaviour
{
    public string myName = "RAGNAGUS";
    public int myAge = 26;
    public float mySpeed = 10.2f;
    public int health = 100;
    public int score = 120;
    public bool hasAllKeys; //Default is False
    public int ammoCount = 30;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + myName + " and I am " + myAge + " years old.");
        Debug.Log("Speed: " + mySpeed);
        Debug.Log("Health: " + health);
        Debug.Log("Score: " + score);
        Debug.Log("Has All Keys: " + hasAllKeys);
        Debug.Log("Ammo Count: " + ammoCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
