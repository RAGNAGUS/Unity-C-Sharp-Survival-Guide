using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Box Collider : Is Trigger
//add Rigibody

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //add points
            //add power up ability
            Destroy(this.gameObject);
        }
    }
}
