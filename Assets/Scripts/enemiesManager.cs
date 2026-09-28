using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesManager : MonoBehaviour
{
    public Enemy[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = FindObjectsOfType<Enemy>();

        Debug.Log(enemies[enemies.Length-1].damagePoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SetAllEnemiesDamagePointsTo(int value )
{
    for(int I = 0; I < enemies.Length, i++);
    {
        
    }
}
}
