using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // new Vector3(1, 0, 0) * 5 * real time
        transform.Translate(Vector3.right * _speed * Time.deltaTime);

        // new Vector3(-1, 0, 0) * 5 * real time
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontalInput, 0, 0 * _speed * Time.deltaTime));
    }
}