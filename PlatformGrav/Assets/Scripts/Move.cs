using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    // Use this for initialization
    public bool stop;
    public static float SPEED;
    public float speed;

    public GameObject createThings;

	void Start () {
        if (SPEED == 0)
        {
            SPEED = 20f;
        }

        speed = SPEED;
        createThings = GameObject.Find("TriggerLoop");
	}
	
	// Update is called once per frame
	void Update () {

        speed = SPEED;
        transform.Translate(Vector3.left * SPEED * Time.deltaTime);

        if(transform.position.x<=-220f)
        {
            transform.position = new Vector3(545f, transform.position.y, transform.position.z);
            createThings.gameObject.GetComponent<loopThings>().create = true;
        }
  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "Spike")
        {
            if (other.GetComponent<playerBox>())
            {
                GameObject ending = GameObject.Find("Player");
                ending.GetComponent<Menu>().Menuetwo();
            }
        }
    }
}
