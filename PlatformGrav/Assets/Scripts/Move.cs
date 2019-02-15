using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    // Use this for initialization
    public bool stop;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
  
            transform.Translate(Vector3.left * 20 * Time.deltaTime);

        if(transform.position.x<=-200f)
        {
            transform.position = new Vector3(575f, transform.position.y, transform.position.z);
        }
  
    }
}
