using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject MeleeMonster;

    GameObject spawn_object;
    public Text time_count;

    public float Game_Time;
    float game_timer = 0;
    float time = 0;
    public float spawn_rate;

    bool spawning;
    public float x_zone = 6;
    Vector3 spawn_position;

    // Start is called before the first frame update
    void Start()
    {
        spawning = true;
        //Debug.Log("Child is " + this.transform.GetChild(0).name);
        spawn_object = this.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        spawn_position = new Vector3(spawn_object.transform.position.x + Random.Range(-x_zone, x_zone), spawn_object.transform.position.y, spawn_object.transform.position.z);
        time_count.text = "" + game_timer;

        game_timer += Time.deltaTime;
        if (game_timer > Game_Time)
        {
            game_timer = Game_Time;
            spawning = false;
            SceneManager.LoadScene("GameOverScreen");
        }


        time += Time.deltaTime;
        if (spawning)
        {
            if (time > spawn_rate)
            {
                //Debug.Log("Spawned");
                Instantiate(MeleeMonster, spawn_position, Quaternion.identity);
                time = 0;
            }
        }
        else 
        {
            Debug.Log("Game Over");
        }
    }
}
