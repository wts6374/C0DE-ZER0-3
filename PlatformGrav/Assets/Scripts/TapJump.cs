using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapJump : MonoBehaviour {
 
    //Vector3 impulseForce;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        Physics2D.gravity = new Vector2(0, -50f);
    }
	
	// Update is called once per frame
	void Update () {
        TouchInput();
        //ClickInput();
	}

    public void TouchInput()
    {
        //Debug.Log(Input.touches.Length);
        if(Input.touches.Length == 1)
            if(Input.touches[0].phase == TouchPhase.Began)
            {
               

                // reverse gravity
                Physics2D.gravity = -(Physics2D.gravity);

                // zero out velocity
                player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        
    
    }

    public void ClickInput()
    {
        Debug.Log("CLICK ENTER");

        // reverse gravity
        Physics2D.gravity = -(Physics2D.gravity);

        // zero out velocity
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    
}
