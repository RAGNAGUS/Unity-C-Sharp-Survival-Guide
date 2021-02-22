using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable<T> // T is Generic type;
{
    int Health { get; set; }

    void Damage(T damageAmount);
    
    /*void Damage(int damageAmount);

    void Damage(float damageAmount);

    void Damage(GameObject damageAmount);*/
}
