/*
 * Code obtained and derived from "How to make a HEALTH BAR in Unity!" by
 * Brackeys on YouTube
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

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
        if (currentHealth <= 0)
        {
            Die();
        }
       
    }

    public void OnLevelUp()
    {
        Debug.Log("LEVEL UP!");
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthBar.SetBarValue(currentHealth);

    }
    void ChangeInk(int amount)
    {
        currentInk += amount;
        inkBar.SetBarValue(currentInk);
    }

    public void Die()
    {
        SceneManager.LoadScene("GameOverScreen");
    }

}
