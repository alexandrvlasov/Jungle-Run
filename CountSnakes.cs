using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class CountSnakes : MonoBehaviour
{
    private int enemiesOnSence;

    public static CountSnakes Instance { get; set; }

    private void Awake()
    {
        Instance = this;
    }

    public virtual void EnemiesCount()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        enemiesOnSence = enemies.Length;
        Debug.Log(enemiesOnSence);

        if (enemiesOnSence == 0)
        {
            Hero.Instance.SetWinPanel();
        }
    }
}
