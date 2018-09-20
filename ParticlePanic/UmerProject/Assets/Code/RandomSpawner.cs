using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {
    float timer = 6;
    public GameObject projectile;
    public Transform thisPosition;
    int ammo = 1;

    public GameObject alert;
    public float offsetx;
    public float offsety;
    Vector3 newPos;

    int randomValue;
    int alertAmmo = 1;

    private void Start()
    {
        randomValue = Random.Range(0, 2);
        newPos = new Vector3(thisPosition.position.x + offsetx, thisPosition.position.y + offsety, thisPosition.position.z);
        SpawnAlert();
    }

    void Update()
    {
        CheckTimer();
        SpawnProjectile();
    }
    void CheckTimer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 6;
            ammo++;
            alertAmmo++;
            randomValue = Random.Range(0, 2);
            SpawnAlert();
        }
    }

    void SpawnAlert()
    {
        if(randomValue == 1 && alertAmmo == 1)
        {
            Instantiate(alert, newPos, Quaternion.identity);
        }
    }

    void SpawnProjectile()
    {
        if (timer <= 0.1f && ammo == 1)
        {
            ammo--;
            alertAmmo--;
            if (randomValue == 1)
            {
                Instantiate(projectile, thisPosition);
            }
        }
    }

}
