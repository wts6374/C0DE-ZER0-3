using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopThings : MonoBehaviour {

    public float fTimer = 0.2f;
    public Transform coin;
    public Transform spike;
    public Transform slow;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Will spawn in a new coin or obstacle constantly
        fTimer -= Time.deltaTime;
        int change = Random.Range(0, 12);

        if (fTimer<=0.0f)
        {
            fTimer = 0.2f;
            if (change >= 9 && change<=11)
            {
                Vector3 pos = new Vector3(200, Random.Range(-5, 10), -0.19f);
                Instantiate(spike, pos, Quaternion.identity);
            }
            else if(change>=12)
            {
                Vector3 pos = new Vector3(200, Random.Range(-5, 10), -0.19f);
                Instantiate(slow, pos, Quaternion.identity);
            }
            else
            {
                Vector3 pos = new Vector3(200, Random.Range(-6, 11), -0.19f);
                Instantiate(coin, pos, Quaternion.identity);
            }
        }
	}


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            other.transform.position = new Vector3(575, other.transform.position.y, other.transform.position.z);
        }

        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
        }

    }
}
