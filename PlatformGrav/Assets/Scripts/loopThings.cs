using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopThings : MonoBehaviour {

    public float fTimer = 2.0f;
    public Transform coin;
    public Transform spike;
    public Transform slow;
    public Transform mag;
    public Transform ground;

    public float[] xPos;

    // Use this for initialization
    void Start () {

        xPos = new float[6];

        xPos[0] = gameObject.transform.position.x;
 
        xPos[1] = gameObject.transform.position.x+350;

        xPos[2] = gameObject.transform.position.x-350;

        xPos[3] = gameObject.transform.position.x+700;
 
        xPos[4] = gameObject.transform.position.x-700;

        xPos[5] = gameObject.transform.position.x+800;

      /* xPos[6] = 400;
 
        xPos[7] = 350;
   
        xPos[8] = 250;

        xPos[9] = 150;

        xPos[10] = 60;

        xPos[11] = 1050;
        xPos[12] = 1100;

        xPos[13] = 1200;
        xPos[14] = 1250;
        xPos[15] = 1300;
        xPos[16] = 1350;
        xPos[17] = 1400;
        xPos[18] = 1450;
        xPos[19] = 1500;
        xPos[20] = 1550;
        xPos[21] = 1650;


        xPos[22] = 2350;


        xPos[23] = 3000;

        xPos[24] = 4000;*/
    }
	
	// Update is called once per frame
	void Update () {

        //Will spawn in a new coin or obstacle constantly
        fTimer -= 0.1f;

        if (fTimer<=0.0f)
        {
            for (int i = 0; i < xPos.Length; i++)
            {
                int change = Random.Range(0, 30);
                if (change >= 13 && change <= 15)
                {
                        Vector3 pos = new Vector3(xPos[i], Random.Range(gameObject.transform.position.y-3, gameObject.transform.position.y+3), 0f);
                        Instantiate(spike, pos, Quaternion.identity);
                }
                if (change == 18)
                {
                    Vector3 pos = new Vector3(xPos[i], Random.Range(gameObject.transform.position.y - 3, gameObject.transform.position.y + 3), 0f);
                    Instantiate(mag, pos, Quaternion.identity);
                }
                else if (change >= 19&&change<=21)
                {
                    Vector3 pos = new Vector3(xPos[i], Random.Range(gameObject.transform.position.y - 3, gameObject.transform.position.y + 3), 0f);
                    Instantiate(slow, pos, Quaternion.identity);
                }
                else if (change >= 8 && change <= 12)
                {
                    Vector3 pos = new Vector3(xPos[i], Random.Range(gameObject.transform.position.y - 3, gameObject.transform.position.y + 3), 0f);
                    Instantiate(ground, pos, Quaternion.identity);
                }
                else
                {
                    Vector3 pos = new Vector3(xPos[i], Random.Range(gameObject.transform.position.y - 3, gameObject.transform.position.y + 3), 0f);
                    Instantiate(coin, pos, Quaternion.identity);
                }
            }

            fTimer = 3.0f;
        }


	}


}
