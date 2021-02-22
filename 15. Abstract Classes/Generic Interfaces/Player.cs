using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable<int> //Generic type
{
    public int Health { get; set; }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
