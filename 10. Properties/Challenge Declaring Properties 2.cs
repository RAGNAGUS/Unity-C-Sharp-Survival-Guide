using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    GameManager gm = new GameManager();

    public Test()
    {
        gm.Name = "RAGNAGUS";
        Debug.Log(gm.Name);
    }

}
public class GameManager : MonoBehaviour
{
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}
