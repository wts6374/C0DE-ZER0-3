using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (RainCoin.RAINING)
        {
            transform.position += Vector3.down * .1f;
        }
	}
}
