using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class ItemManager : MonoBehaviour
{   
    public GameObject burgerPrefab;
    public GameObject jellyfishPrefab;
    private int i;
    public float spawnTime;
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

        if(countdown >= 5)
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

    void DropBurger()
    {
        Vector2 positionItem = new Vector2(Random.Range(-7, 7), 7);
        Instantiate(burgerPrefab, burgerPrefab.transform);
    }

    void DropJellyfish()
    {
        Vector2 positionItem = new Vector2(Random.Range(-7, 7), 7);
        Instantiate(jellyfishPrefab, jellyfishPrefab.transform);
    }
}
