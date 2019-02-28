using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private static ScoreManager instance = null;
    private playerBox PlayerBox;
    public float finalscore;
    private GameObject player;
    // Game Instance Singleton
    public static ScoreManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        player = GameObject.FindGameObjectWithTag("Player");
        //DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {

    }
    public void Gameover()
    {
        player.GetComponent<playerBox>().finalscore = player.GetComponent<playerBox>().score;
        finalscore = player.GetComponent<playerBox>().finalscore;
        DontDestroyOnLoad(this.gameObject);
    }
}
