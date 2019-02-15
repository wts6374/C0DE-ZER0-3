using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopThings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.tag == "Ground" || other.gameObject.tag == "Coin" ))
        {
            other.transform.position = new Vector3(575, other.transform.position.y, other.transform.position.z);
        }

    }
}
