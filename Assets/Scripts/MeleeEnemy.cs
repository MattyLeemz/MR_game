using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float speed;

    public StatBar healthBar;
    public Animator anim;

    [SerializeField] GameObject player;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetBarMax(maxHealth);
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
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

        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthBar.SetBarValue(currentHealth);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("I have hit " + collision.transform.name);
            //Destroy(this.gameObject);
        }
    }
}
