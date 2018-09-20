using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject[] spawners;

    public int spawnerCounter;

    private void Start()
    {
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i].SetActive(false);
        }
        SetNextSpawnerActive();
    }

    public void SetNextSpawnerActive()
    {
        spawners[spawnerCounter].SetActive(true);
        spawnerCounter++;
    }
}
