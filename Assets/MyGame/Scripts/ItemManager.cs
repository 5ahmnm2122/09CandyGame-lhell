
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;

public class ItemManager : MonoBehaviour
{   
    public GameObject burgerPrefab;
    public GameObject jellyfishPrefab;
    private int i;
    private float spawnTime;
    public float countdown = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(1, 10);

        StartSpawn();
    }

    void StartSpawn()
    {
        if (i > 5)
        {
            InvokeRepeating("burgerPrefab", 50f, spawnTime);
        }
        else
        {
            InvokeRepeating("jellyfishPrefab", 50f, spawnTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        countdown += Time.deltaTime;

        if(countdown >= 2)
        {
            float randomChance = Random.Range(0.0f, 1.0f);
            if(randomChance < 0.5f)
            {
                DropBurger();
            }
            else
            {
                DropJellyfish();
            }

            countdown = 0;
        }

        if(transform.position.y <= -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
    Vector2 GetSpawnPoint()
        {
            float x = Random.Range (-7, 7);
            return new Vector2(x, 8);
        } 
    void DropBurger()
    {
        Instantiate(burgerPrefab, GetSpawnPoint(), Quaternion.identity);
    }

    void DropJellyfish()
    {
        Instantiate(jellyfishPrefab, GetSpawnPoint(), Quaternion.identity);
    }


}
