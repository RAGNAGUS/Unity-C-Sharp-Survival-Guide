using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectDiffculty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy, //0
        Normal, //1
        Hard, //2
        Expert, //3
    }
    public LevelSelector currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        switch (currentLevel)
        {
            case LevelSelector.Easy:
                Debug.Log("You Selected Easy!");
                break;
            case LevelSelector.Normal:
                Debug.Log("You Selected Normal!");
                break;
            case LevelSelector.Hard:
                Debug.Log("You Selected Hard!");
                break;
            case LevelSelector.Expert:
                Debug.Log("You Selected Expert!");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
