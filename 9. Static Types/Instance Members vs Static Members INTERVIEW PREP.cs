using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server
{
    public int id;
    public string name;

    public static int connectionCount;

    public Server()
    {
        connectionCount++;
    }

}

public class Player : MonoBehaviour
{
    private void Start()
    {
        Server p1 = new Server();
        Server p2 = new Server();
        Server p3 = new Server();

        Debug.Log(Server.connectionCount);

    }
}
