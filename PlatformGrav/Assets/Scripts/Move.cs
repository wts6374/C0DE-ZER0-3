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
        if (stop == false)
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
    }
}
