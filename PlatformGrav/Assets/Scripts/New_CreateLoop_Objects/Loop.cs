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

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GroundNew" || other.gameObject.tag == "Spike")
        {
            Destroy(other.gameObject);
   
        }
        else
        {
            Vector2 looping = GameObject.Find("Spawn Objects").GetComponent<RectTransform>().position;
            other.gameObject.transform.position = new Vector2(looping.x, other.transform.position.y);
        }
    }
}
