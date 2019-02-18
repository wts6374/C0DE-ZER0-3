using System.Collections;
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
        displayScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        displayScore = (int)score;
        scoreText.text = "Score: " + displayScore.ToString() + "\nMultiplier: " + multiplier.ToString();
    }

    //fixed update makes score incrment every second by 1
    void FixedUpdate()
    {
        score += .05f * multiplier;
    }
}
