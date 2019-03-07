using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public GameObject spike;
    public GameObject coin;
    public GameObject ground;
    public GameObject slow;
    public GameObject mag;
    public GameObject rain;

    public List<GameObject> objects;


    float width;
    float height;
    float centerX;

    // Use this for initialization
    void Start () {

        Vector2 looping = GetComponent<RectTransform>().position;
        //gameObject.transform.position = new Vector2(looping.x, transform.position.y);
        width = 200f;
        height = 3.5f;

        centerX = GetComponent<RectTransform>().position.x;
        objects = new List<GameObject>();

        for (int x = 0; x < 30; x++)
        {
            objects.Add(SpawningObjects());
        }
	}
	
	// Update is called once per frame
	void Update () {
		for(int x = 0; x < 30; x++)
        {
            if (objects[x] == null)
            {
                GameObject temp = SpawningObjects();
                //Debug.Log("Missing: " + x);
                if (temp.tag != "Coin")
                {
                    objects[x] = temp;
                }
            }
        }
	}

    GameObject SpawningObjects()
    {
        int num = Random.Range(0, 21);

        GameObject temp = null;


        
        temp = Instantiate(rain, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);



        if (num > 11 && num < 15)
            temp = Instantiate(spike, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num > 0 && num < 12)
            temp = Instantiate(coin, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num > 14 && num < 18)
            temp = Instantiate(ground, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num == 18)
            temp = Instantiate(rain, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num == 19)
            temp = Instantiate(slow, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num == 20)
            temp = Instantiate(mag, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);

        return temp;
        
    }
}
