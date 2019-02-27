using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public GameObject spike;
    public GameObject coin;
    public GameObject ground;
    public GameObject slow;
    public GameObject mag;

    List<GameObject> objects;

    
     

	// Use this for initialization
	void Start () {
        float height = 4f;//(GetComponent<RectTransform>().rect.height);
        float width = 10f;//GetComponent<RectTransform>().rect.width / 2f;
        float centerX = GetComponent<RectTransform>().position.x + height;
        objects = new List<GameObject>();
        for(int x = 0; x < 30; x++)
        {
            

            int num = Random.Range(0, 5);

            if (num == 0)
                Instantiate(spike, new Vector3(centerX + Random.Range(-width, width), 0 + Random.Range(-height, height) , 0), Quaternion.identity);
            else if (num == 1)
                Instantiate(coin, new Vector3(centerX + Random.Range(-width, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
            else if (num == 2)
                Instantiate(ground, new Vector3(centerX + Random.Range(-width, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
            else if (num == 3)
                Instantiate(slow, new Vector3(centerX + Random.Range(-width, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
            else if (num == 4)
                Instantiate(mag, new Vector3(centerX + Random.Range(-width, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawningObjects()
    {

    }
}
