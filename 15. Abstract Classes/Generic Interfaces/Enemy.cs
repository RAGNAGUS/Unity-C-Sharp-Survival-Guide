using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable<int> //IDamagable<GameObject> //Generic type
{
    public int Health { get; set; }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }
}
