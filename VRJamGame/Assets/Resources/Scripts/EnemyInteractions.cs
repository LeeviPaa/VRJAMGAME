﻿using UnityEngine;
using System.Collections;

public class EnemyInteractions : MonoBehaviour {

    public float EnemyMaxHealth = 100;
    public float EnemyCurrentHealth;
    public Vector3 Home = new Vector3(0,0,0);
    private bool HasExploded = false;
	void Start () 
    {
        EnemyCurrentHealth = EnemyMaxHealth;
	}

    public void TakeDamage(float damage)
    {
        EnemyCurrentHealth -= damage;
        CheckDeath();
    }
    void CheckDeath()
    {
        if(EnemyCurrentHealth <= 0)
        {
            EnemyDeath();
        }
    }

    private void EnemyDeath()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
        transform.position = Home;
        transform.gameObject.SetActive(false);

    }

    public void SetHome(Vector3 set)
    {
        Home = set;
    }
    public void Exploded()
    {
        HasExploded = true;
        // what to do after the explosion? D:
    }

}