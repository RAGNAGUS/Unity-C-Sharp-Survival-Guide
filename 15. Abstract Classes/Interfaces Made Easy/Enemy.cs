using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable, Shoot
{
    public int Health
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }
}
