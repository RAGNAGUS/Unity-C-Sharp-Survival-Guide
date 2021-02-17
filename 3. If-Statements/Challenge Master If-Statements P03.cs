using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _point;
    private bool _hasMessageBeenSent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _point += 10;
            Debug.Log(_point);
        }

        if (_point >= 50 && _hasMessageBeenSent == false)
        {
            Debug.Log("You are awesome!");
            _hasMessageBeenSent = true;
        }
    }
}
