﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour {

    public float timer;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= 10) { 
            SceneManager.LoadScene(1);
                };
	}
}
