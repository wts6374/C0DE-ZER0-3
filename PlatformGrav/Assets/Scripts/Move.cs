using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    // Use this for initialization
    public bool stop;
    public static float SPEED;
    public float speed;
	void Start () {
        if (SPEED == 0)
        {
            SPEED = 20f;
        }

        speed = SPEED;
	}
	
	// Update is called once per frame
	void Update () {

        speed = SPEED;
        transform.Translate(Vector3.left * SPEED * Time.deltaTime);

        if(transform.position.x<=-200f)
        {
            transform.position = new Vector3(575f, transform.position.y, transform.position.z);
        }
  
    }
}
