using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = new Vector2(50, 0);
    }
}
