using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    GameManager gm = new GameManager();

    public Test()
    {
        Debug.Log(gm.Speed); //Able to read speed value

        //gm.Speed = 5; //Not able to edit speed value
    }
}
public class GameManager : MonoBehaviour
{
    private float _speed;

    public float Speed
    {
        get
        {
            return _speed;
        }
        private set
        {
            _speed = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Speed = 10f;
        Debug.Log(Speed);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
