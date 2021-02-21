using System.Collections;
using System.Collections.Generic; //allow to use List
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> names = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (var name in names)
        {
            Debug.Log(name);
        }
    }
    private void Update()
    {
        var nameToRemove = names[Random.Range(0, names.Count)];

        if (Input.GetKeyDown(KeyCode.Space))
        {
            names.Remove(nameToRemove);

            foreach (var name in names)
            {
                Debug.Log(name);
            }

            Debug.Log("We removed: " + nameToRemove);
        }
    }
}
