using System; // Need to add Using System to use Action
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;

    public static Action<int> OnDamageReceived;

    public int Health { get; set; }

    private void Start()
    {
        Health = 10;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnDamageReceived != null)
            {
                OnDamageReceived(Health);
            }
        }

    }


}
