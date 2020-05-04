using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public StatBar healthBar;
    public Animator anim;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetBarMax(maxHealth);
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeHealth(-10);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeHealth(5);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("I'm trying to trigger the Walk Animation.");
            anim.Play("Walk Animation", -1, 0f);
        }
    }

    void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthBar.SetBarValue(currentHealth);

    }
}
