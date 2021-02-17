using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeReviewMasterVariablesPart02 : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public float attackStrenght;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Description: " + itemDescription);
        Debug.Log("Attack: " + attackStrenght);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
