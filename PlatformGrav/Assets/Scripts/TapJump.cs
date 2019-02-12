using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapJump : MonoBehaviour {
 
    Vector3 impulseForce;

	// Use this for initialization
	void Start () {
        // sets force for impulse
        impulseForce = new Vector3(0.0f, 3.0f, 0.0f) * 2.0f;
    }
	
	// Update is called once per frame
	void Update () {
        TouchInput();
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
                    this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    // adds impulse force to increase speed of switching
                    this.GetComponent<Rigidbody>().AddForce(impulseForce, ForceMode.Impulse);
                    // reverse force for next gravity switch
                    impulseForce = -impulseForce;
                }
            }
        }
    }
}
