using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public enum Difficulty
    {
        Easy,// 0
        Normal,// 1
        Hard,// 2
        Expert// 3
    }

    public Difficulty selectedDifficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)selectedDifficulty);
        // Add Scene to Build Setting to use this enum
    }
}
