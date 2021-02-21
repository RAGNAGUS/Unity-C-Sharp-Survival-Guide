using System.Collections;
using System.Collections.Generic; //allow to use List
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> player = new List<GameObject>();

    public int SpawnCount { get; set; }

    private bool _initColorChange;

    public List<GameObject> createdObject = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpawnCount == 10)
            {
                _initColorChange = true;
                return;
            }

            var objectToSpawn = player[Random.Range(0, player.Count)];
            var x = Random.Range(-10, 10);
            var y = Random.Range(-10, 10);
            var pos = new Vector3(x, y, 0);
            var go = Instantiate(objectToSpawn, pos, Quaternion.identity) as GameObject;

            createdObject.Add(go);

            SpawnCount++;
        }

        if (_initColorChange)
        {
            _initColorChange = false;

            foreach (var item in createdObject)
            {
                item.GetComponent<MeshRenderer>().material.color = Color.red;
            }

            createdObject.Clear();
            SpawnCount = 0;

        }
    }
}
