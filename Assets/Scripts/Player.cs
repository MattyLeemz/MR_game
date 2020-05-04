/*
 * Code obtained and derived from "How to make a HEALTH BAR in Unity!" by
 * Brackeys on YouTube
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Level level;
    
    public int maxHealth = 100;
    public int maxInk = 100;
    public int currentHealth;
    public int currentInk;

    public StatBar healthBar;
    public StatBar inkBar;

    void Start()
    {
        level = new Level(1, OnLevelUp);

        currentHealth = maxHealth;
        currentInk = maxInk;
        healthBar.SetBarMax(maxHealth);
        inkBar.SetBarMax(maxInk);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeHealth(-20);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeHealth(10);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeInk(-20);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeInk(10);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            level.AddExp(100);
        }
    }

    public void OnLevelUp()
    {
        Debug.Log("LEVEL UP!");
    }

    void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthBar.SetBarValue(currentHealth);

    }
    void ChangeInk(int amount)
    {
        currentInk += amount;
        inkBar.SetBarValue(currentInk);
    }

}
