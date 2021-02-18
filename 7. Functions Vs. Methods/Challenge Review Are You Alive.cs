using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !IsDead())
        {
            Damage(Random.Range(5, 20));
        }
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (IsDead())
        {
            health = 0;
            Debug.Log("The Player has died!");
        }
    }

    public bool IsDead()
    {
        return health < 1;
    }
}

