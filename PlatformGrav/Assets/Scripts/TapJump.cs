using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapJump : MonoBehaviour {
 
    Vector3 impulseForce;
    GameObject player;

	// Use this for initialization
	void Start () {
        // sets force for impulse
        impulseForce = new Vector3(0.0f, 5.0f, 0.0f) * 2.0f;
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        TouchInput();
        //ClickInput();
	}

    void TouchInput()
    {


        // checks for touch input
        foreach (Touch touch in Input.touches)
        {
            // if touch is detected, register
            if (touch.phase == TouchPhase.Began)
            {
                // Construct a ray from the current touch coordinates
                var ray = Camera.main.ScreenPointToRay(touch.position);

                if (Physics.Raycast(ray))
                {
                    // reverse gravity
                    Physics.gravity = -(Physics.gravity);
                    // zero out velocity
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    // adds impulse force to increase speed of switching
                    player.GetComponent<Rigidbody>().AddForce(impulseForce, ForceMode.Impulse);
                    // reverse force for next gravity switch
                    impulseForce = -impulseForce;
                }
            }
        }
    }

    public void ClickInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // reverse gravity
            Physics.gravity = -(Physics.gravity);
            // zero out velocity
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            // adds impulse force to increase speed of switching
            player.GetComponent<Rigidbody>().AddForce(impulseForce, ForceMode.Impulse);
            // reverse force for next gravity switch
            impulseForce = -impulseForce;
        }
    }
}
