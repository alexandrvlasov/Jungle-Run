using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : Entity
{
    private GameManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<GameManager>();
        lives = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
            lives--;
            Debug.Log("у змеи " + lives);
        }

        if (lives < 1)
        {
            Die();
            levelManager.EnemyDied();
        }
    }
}
