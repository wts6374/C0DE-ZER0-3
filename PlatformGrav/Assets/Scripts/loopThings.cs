﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopThings : MonoBehaviour {

    public bool create = false;
    public Transform coin;
    public Transform spike;
    public Transform slow;
    public Transform mag;
    public Transform ground;

    public int[] xPos;

    // Use this for initialization
    void Start () {

        xPos = new int[40];

        xPos[0] = 550;
        xPos[1] = 600;
        xPos[2] = 650;
        xPos[3] = 700;
        xPos[4] = 750;
        xPos[5] = 800;
        xPos[6] = 850;
        xPos[7] = 900;
        xPos[8] = 950;
        xPos[9] = 1000;
        xPos[10] = 500;
        xPos[11] = 450;
        xPos[12] = 400;
        xPos[13] = 300;
        xPos[14] = 350;
        xPos[15] = 200;
        xPos[16] = 250;
        xPos[17] = 100;
        xPos[18] = 150;
        xPos[19] = 60;

        xPos[0] = 1050;
        xPos[1] = 1100;
        xPos[2] = 1150;
        xPos[3] = 1200;
        xPos[4] = 1250;
        xPos[5] = 1300;
        xPos[6] = 1350;
        xPos[7] = 1400;
        xPos[8] = 1450;
        xPos[9] = 1500;
        xPos[10] = 1550;
        xPos[11] = 1650;
        xPos[12] = 2400;
        xPos[13] = 2300;
        xPos[14] = 2350;
        xPos[15] = 2200;
        xPos[16] = 2000;
        xPos[17] = 3000;
        xPos[18] = 3500;
        xPos[19] = 4000;
    }
	
	// Update is called once per frame
	void Update () {

        //Will spawn in a new coin or obstacle constantly
        

        if (create==true)
        {
            for (int i = 0; i < xPos.Length; i++)
            {
                int change = Random.Range(0, 30);
                if (change >= 13 && change <= 15)
                {
                        Vector3 pos = new Vector3(i, Random.Range(-5, 10), -0.19f);
                        Instantiate(spike, pos, Quaternion.identity);
                }
                if (change == 18)
                {
                    Vector3 pos = new Vector3(i, Random.Range(-5, 10), -0.19f);
                    Instantiate(mag, pos, Quaternion.identity);
                }
                else if (change >= 19&&change<=21)
                {
                    Vector3 pos = new Vector3(i, Random.Range(-5, 10), -0.19f);
                    Instantiate(slow, pos, Quaternion.identity);
                }
                else if (change >= 8 && change <= 12)
                {
                    Vector3 pos = new Vector3(i, Random.Range(-1, 7), -0.19f);
                    Instantiate(ground, pos, Quaternion.identity);
                }
                else
                {

                 Vector3 pos = new Vector3(i, Random.Range(-6, 11), -0.19f);
                 Instantiate(coin, pos, Quaternion.identity);
                }
            }

            create = false;
        }
	}


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            other.transform.position = new Vector3(545, other.transform.position.y, other.transform.position.z);
        }

       else if (other.gameObject.tag == "Coin"|| other.gameObject.tag == "Spike"|| other.gameObject.tag == "SlowAbility"|| other.gameObject.tag == "Mag"|| other.gameObject.tag == "GroundNew")
        {
            Destroy(other.gameObject);
        }

    }
}
