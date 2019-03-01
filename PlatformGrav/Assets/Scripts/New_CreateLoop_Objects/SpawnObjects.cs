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
        width = 100f;
        height = 4f;

        centerX = GetComponent<RectTransform>().position.x;
        objects = new List<GameObject>();

        for (int x = 0; x < 30; x++)
            objects.Add(SpawningObjects());
	}
	
	// Update is called once per frame
	void Update () {
		for(int x = 0; x < 30; x++)
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
        int num = Random.Range(0, 5);

        GameObject temp = null;

        if (num == 0)
            temp = Instantiate(spike, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num == 1)
            temp = Instantiate(coin, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num == 2)
            temp = Instantiate(ground, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num == 3)
            temp = Instantiate(slow, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        else if (num == 4)
            temp = Instantiate(mag, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);

        return temp;
        
    }
}
