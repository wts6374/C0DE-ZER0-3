using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    public bool movingDown, rain;

	// Use this for initialization
	void Start () {
        movingDown = false;
	}
	
	// Update is called once per frame
	void Update () {
        //if moving down, make coin slowly move down
        rain = RainCoin.RAINING;
		if (RainCoin.RAINING)
        {
            gameObject.transform.position += Vector3.down * .1f;
        }
	}
}
