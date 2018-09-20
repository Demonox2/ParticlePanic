using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour
{

    public AudioSource music;

    private void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("music");
        if (objects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
