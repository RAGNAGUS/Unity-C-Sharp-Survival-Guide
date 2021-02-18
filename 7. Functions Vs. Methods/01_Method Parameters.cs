using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        Sum(20, 30);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(10);
        }
    }

    private void Sum(int a, int b)
    {
        Debug.Log(a + b);
    }

    public void Damage(int damageAmount) 
    {
        health -= damageAmount;

        if (health < 1)
        {
            Destroy(this.gameObject);
        }

    }

}

