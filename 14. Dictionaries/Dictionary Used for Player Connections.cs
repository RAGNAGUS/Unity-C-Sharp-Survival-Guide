using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public int id;

    public Player(int id)
    {
        this.id = id;
    }
}

public class PlayerConnections : MonoBehaviour
{
    public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();

    Player p1, p2, p3;

    private void Start()
    {
        p1 = new Player(268325);
        p1.name = "Jimmy";

        p2 = new Player(268328);
        p2.name = "Kyle";

        p3 = new Player(268320);
        p3.name = "James";

        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*var player = playerDictionary[p1.id];
            Debug.Log(player.name + "(" + player.id + ")" + " Connected");*/
            foreach (int item in playerDictionary.Keys)
            {
                var player = playerDictionary[item];
                Debug.Log(player.name + "(" + player.id + ")" + " Connected");
            }
        }
    }
}
