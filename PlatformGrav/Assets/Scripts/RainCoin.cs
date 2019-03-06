using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCoin : PowerUp {

    public GameObject coinPrefab, rainCoinPrefab;
    public Vector2 playerPos;
    public static bool RAINING;

    public override void Start()
    {
        base.Start();
        RAINING = false;
    }

    // Update is called once per frame
    public override void Update () {
        playerPos = GameObject.Find("Player").transform.position;

        base.Update();

        //spawns them every other second
        if (isActive && coinPrefab != null)
        {
            if ((int)duration % 2 == 1)
            {
                //rain coins at random positions on screen
                Instantiate(coinPrefab, new Vector2(Random.Range(playerPos.x + 25, playerPos.x + 60),
                    Random.Range(playerPos.y + 9, playerPos.y + 20)), Quaternion.identity);

            }

            RAINING = true;

        }
        else
        {
            RAINING = false;
        }
	}

    public void SetActive()
    {
        Instantiate(rainCoinPrefab, GameObject.Find("Player").transform.position , Quaternion.identity);
    }
}
