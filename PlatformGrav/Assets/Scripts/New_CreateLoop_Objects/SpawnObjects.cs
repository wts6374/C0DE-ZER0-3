using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public GameObject spike;
    public GameObject coin;
    public GameObject ground;
    public GameObject slow;
    public GameObject mag;

    public List<GameObject> objects;


    float width;
    float height;
    float centerX;

    // Use this for initialization
    void Start () {

        Vector2 looping = GetComponent<RectTransform>().position;
        //gameObject.transform.position = new Vector2(looping.x, transform.position.y);
        width = 400f;
        height = 3.5f;

        centerX = GetComponent<RectTransform>().position.x;
        objects = new List<GameObject>();

        for (int x = 0; x < 10; x++)
            objects.Add(SpawningObjects());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		for(int x = 0; x < 5; x++)
        {
            if (objects[x] == null)
            {
                Debug.Log("Missing: " + x);
                objects[x] = SpawningObjects();
            }
        }
	}

    GameObject SpawningObjects()
    {
        int num = Random.Range(1, 100);

        GameObject temp = null;

        if (num > 49 && num < 65)
        {
            //spike
            temp = Instantiate(spike, new Vector3(Random.Range(-60, 0), 0 + Random.Range(-height, height), -1), Quaternion.identity);
        }
        else if (num > 24 && num < 50)
        {
            //coin
            temp = Instantiate(coin, new Vector3(Random.Range(-60, 0), 0 + Random.Range(-height, height), -1), Quaternion.identity);
        }
        else if (num > 0 && num < 25)
        {
            //ground
            temp = Instantiate(ground, new Vector3(Random.Range(-60, 0), 0 + Random.Range(-height, height), -1), Quaternion.identity);
        }
        else if (num > 64 && num < 80)
        {
            //slow power up
            temp = Instantiate(slow, new Vector3(Random.Range(-60, 0), 0 + Random.Range(-height, height), -1), Quaternion.identity);
        }
        else if (num > 79 && num < 101)
        {
            //coin magnet power up
            temp = Instantiate(mag, new Vector3(Random.Range(-60, 0), 0 + Random.Range(-height, height), -1), Quaternion.identity);
        }

        return temp;
        
    }


}
