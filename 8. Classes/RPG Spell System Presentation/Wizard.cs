using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spell spells;

    public int level;
    public int exp;

    // Start is called before the first frame update
    void Start()
    {
        spells = new Spell("Fire Ball", 1, 1, 30);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spells.levelRequired == level)
            {
                spells.Cast();
                exp += spells.expGained;
            }
        }
    }
}
