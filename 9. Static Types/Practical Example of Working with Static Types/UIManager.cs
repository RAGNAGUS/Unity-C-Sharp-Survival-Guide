using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text activeEnemyText;

    public void UpdateEnemyCount()
    {
        activeEnemyText.text = "Active Enemies: " + SpawnManager.enemyCount;
    }
}
