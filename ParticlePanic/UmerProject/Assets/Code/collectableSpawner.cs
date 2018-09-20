using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableSpawner : MonoBehaviour {

    public Transform spawnLocation1;
    public Transform spawnLocation2;
    public Transform spawnLocation3;
    public Transform spawnLocation4;
    public Transform spawnLocation5;
    public Transform spawnLocation6;
    public Transform spawnLocation7;
    public Transform spawnLocation8;
    public Transform spawnLocation9;
    public Transform spawnLocation10;

    Vector3 chosenSpawnLocation;
    public GameObject collectable;

    float timer;
    int number;
    public static bool collectableSpawned;

    public int maxRange;

    private void Awake()
    {
        SpawnCollectable();
        collectableSpawned = true;
    }

    private void Update()
    {
        TimeManager();
    }

    void TimeManager()
    {
        timer += Time.deltaTime;
        if(timer >= 6)
        {
            timer = 0;
            if (!collectableSpawned)
            {
                SpawnCollectable();
                collectableSpawned = true;
            }
        }

    }

    void SpawnCollectable()
    {
        number = Random.Range(1, maxRange);
        switch (number)
        {
            case 1:
                chosenSpawnLocation = spawnLocation1.position;
                break;
            case 2:
                chosenSpawnLocation = spawnLocation2.position;
                break;
            case 3:
                chosenSpawnLocation = spawnLocation3.position;
                break;
            case 4:
                chosenSpawnLocation = spawnLocation4.position;
                break;
            case 5:
                chosenSpawnLocation = spawnLocation5.position;
                break;
            case 6:
                chosenSpawnLocation = spawnLocation6.position;
                break;
            case 7:
                chosenSpawnLocation = spawnLocation7.position;
                break;
            case 8:
                chosenSpawnLocation = spawnLocation8.position;
                break;
            case 9:
                chosenSpawnLocation = spawnLocation9.position;
                break;
            case 10:
                chosenSpawnLocation = spawnLocation10.position;
                break;

        }
        Instantiate(collectable, chosenSpawnLocation, Quaternion.identity);
    }
}
