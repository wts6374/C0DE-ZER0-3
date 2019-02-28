using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MySceneManager.Instance.score = 0;
        MySceneManager.Instance.multiplier = 0;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Score: " + (int)MySceneManager.Instance.score + "\nMultiplier: " + (int)MySceneManager.Instance.multiplier + "\nCoins: " + MySceneManager.Instance.coins;
    }

    //fixed update makes score incrment every second by 1
    void FixedUpdate()
    {
        MySceneManager.Instance.score += .05f * MySceneManager.Instance.multiplier;
    }
}
