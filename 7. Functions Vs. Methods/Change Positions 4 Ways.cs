using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        ChangePosition(new Vector3(0, 0, 0));

        transform.position = GetPosition(0 ,0 ,0);
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void ChangePosition(Vector3 pos) 
    {
        transform.position = pos;
    }

    public Vector3 GetPosition(float x, float y, float z) 
    {
        Vector3 pos = new Vector3(x, y, z);
        return pos;
    }
}

