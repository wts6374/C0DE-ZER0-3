﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySceneManager : Singleton<MySceneManager> {

    public float score;
    public float multiplier;
    public Text scoreText;
    int displayScore;

	// Use this for initialization
	void Start () {
        //DontDestroyOnLoad(this);
        //displayScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //displayScore = (int)score;
        //int displayMultiplier = (int)(multiplier * 100);
        
        //scoreText.text = "Score: " + (int)score + "\nMultiplier: " + (int)multiplier;
    }

   
}