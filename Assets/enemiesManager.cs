using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesManager : MonoBehaviour
{
    public Enemy[] enemies;

    void Start()
    {
        enemies = FindObjectsOfType<Enemy>();
        
       
        if (enemies.Length > 0)
        {
            Debug.Log(enemies[enemies.Length - 1].damagePoints);
            SetAllEnemiesDamagePointsTo(5);
        }
    }

    void Update()
    {
        
    }

    void SetAllEnemiesDamagePointsTo(int value)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].damagePoints = value;
        }
    }
}