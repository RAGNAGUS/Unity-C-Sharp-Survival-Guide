using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void Start()
    {
        Player.OnDamageReceived += UpdateHealth;
    }

    public void UpdateHealth(int health)
    {
        Debug.Log("Current Health: " + health);
    }
}
