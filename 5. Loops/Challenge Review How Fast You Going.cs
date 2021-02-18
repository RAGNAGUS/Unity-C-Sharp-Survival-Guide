using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int speed = 0;
    public int maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(SpeedUpRoutine());
    }
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpeedUpRoutine()
    {
        while (speed <= maxSpeed)
        {
            speed += 5;
            if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("Your speed is Max");
    }
}

