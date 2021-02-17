using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction = destination - source
        Vector3 directionToFace = _target.position - transform.position;

        Debug.DrawRay(transform.position, directionToFace, Color.green);

        //access our current rotation = Quaternion Look Rotation
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
    }
}