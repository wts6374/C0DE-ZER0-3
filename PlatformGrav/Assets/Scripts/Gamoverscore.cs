using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamoverscore : MonoBehaviour {
    public Text gameovertext;
    public GameObject playerScoreFind;
	// Use this for initialization
	void Start () {
        playerScoreFind = GameObject.FindGameObjectWithTag("ScoreManager");
        SetScore();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void SetScore()
    {
        gameovertext.text = "Score " + playerScoreFind.GetComponent<ScoreManager>().finalscore;
    }
}
