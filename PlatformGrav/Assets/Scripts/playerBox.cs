using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerBox : MonoBehaviour {

    // Use this for initialization
    public bool jump = false;
   public bool stop = false;
    public Camera cam;
   public Rigidbody rb;
  public float score;

    public Text scoreText;
    public Text winText;

    public GameObject endScreen;

    void Start () {
        score = 0;

        stop = false;
        jump = false;

        winText.text = "";

        endScreen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score: " + score.ToString();


        //if (stop == false)
        //{
           
        //    cam.transform.position = new Vector3(rb.transform.position.x + 1.0f, cam.transform.position.y, cam.transform.position.z);

        //    if (Input.GetMouseButtonUp(0)&&jump==true)
        //    {
        //        rb.AddForce(new Vector3(0.0f, 3.0f, 0.0f) * 2.5f, ForceMode.Impulse);
        //        jump = false;
        //    }

        //}
        //else
        //{
        //    cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        //}

        cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);

        endScreen.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y,endScreen.transform.position.z);

	}

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Ground")
        {
            jump = true;
        }

        if (other.gameObject.tag == "End")
        {
            stop = true;
            winText.text = "You Win!!!!";
            Destroy(rb.gameObject);
            endScreen.SetActive(true);
        }

        if (other.gameObject.tag == "Spike")
        {
            stop = true;
            winText.color = Color.red;
            winText.text = "You Lose";
            Destroy(rb.gameObject);
            endScreen.SetActive(true);
        }

        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);

            //plus 40 to score if you pick up a coin
            score += 40;
        }
        
    }

    //fixed update makes score incrment every second by 1
    void FixedUpdate()
    {
        score += 1;
    }
}


