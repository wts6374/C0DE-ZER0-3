using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Use this for initialization
    public bool stop;
    public static float SPEED;
    public float speed;

    void Start()
    {
        if (SPEED == 0)
        {
            SPEED = 20f;
        }

        speed = SPEED;
    }

    // Update is called once per frame
    void Update()
    {

        speed = SPEED;
        transform.Translate(Vector3.left * SPEED * Time.deltaTime);

    }

 
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }

}