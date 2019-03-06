using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerBox : MonoBehaviour
{

    // Use this for initialization
    public bool jump = false;
    public bool stop = false;
    public Camera cam;
    public Rigidbody rb;
    public bool magnet = false;
    public float timer = 0.0f;
    public GameObject endScreen;

    void Start()
    {
        //Camera.main.transform.position.x = gameObject.transform.position.x + 2;
        stop = false;
        jump = false;
        //magnet = true;

        //endScreen.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {



        RaycastHit hit;
        if (magnet == true)
        {
            if (Physics.SphereCast(transform.position, 10, Vector3.right, out hit, 10))
            {
                if (hit.transform.name.Contains("Coin"))
                {
                    Destroy(hit.transform.gameObject);
                    Debug.Log("coin");
                }
            }
            timer += Time.deltaTime;
            if (timer > 10.0f)
            {
                magnet = false;
                timer = 0;
            }
        }

        //scoreText.text = "Score: " + score.ToString();


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

        //cam.transform.position = new Vector3(this.transform.position.x+15, cam.transform.position.y, cam.transform.position.z);//cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);

        //endScreen.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, endScreen.transform.position.z);

    }

    //void OnCollisionEnter2D(Collision2D other)
    //{
    //    //if (other.gameObject.tag == "Ground")
    //    //{
    //    //    jump = true;
    //    //}

    //    //if (other.gameObject.tag == "End")
    //    //{
    //    //    stop = true;
    //    //    winText.text = "You Win!!!!";
    //    //    Destroy(rb.gameObject);
    //    //    endScreen.SetActive(true);
    //    //}

    //    if (other.gameObject.name.Contains("Spike"))
    //    {
    //        //stop = true;
    //        //winText.color = Color.red;
    //        //winText.text = "You Lose";
    //        //Destroy(rb.gameObject);
    //        //endScreen.SetActive(true);
    //        MySceneManager.Instance.finalScore = MySceneManager.Instance.score;
    //        MySceneManager.Instance.score = 0;
    //        MySceneManager.Instance.coins = 0;
    //        MySceneManager.Instance.multiplier = 0;
    //        //Physics.gravity = new Vector3(0, -50, 0);
    //        Physics2D.gravity = new Vector2(0, -50f);
    //        GetComponent<MainMenu>().Menuetwo();
    //    }

    //    if (other.gameObject.tag == "Coin")
    //    {
    //        Destroy(other.gameObject);

    //        // plus 40 to score if you pick up a coin
    //        MySceneManager.Instance.score += 40;
    //    }

    //    if (other.gameObject.tag == "Mag")
    //    {
    //        Destroy(other.gameObject);
    //        magnet = true;
    //    }

    //    if(other.gameObject.tag == "SlowAbility")
    //    {
    //        other.gameObject.GetComponent<SlowDown>().isActive = true;
    //        other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    //        other.gameObject.transform.position = new Vector2(-100, -100);
    //    }

    //}

    //fixed update makes score incrment every second by 1
    void FixedUpdate()
    {
        MySceneManager.Instance.score += .05f;
    }
}


