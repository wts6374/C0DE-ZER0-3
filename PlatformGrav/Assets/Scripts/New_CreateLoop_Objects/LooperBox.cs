using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooperBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<BoxCollider2D>().size = new Vector2(GetComponent<RectTransform>().rect.width, GetComponent<RectTransform>().rect.height - 1);
        GetComponent<BoxCollider2D>().offset = new Vector2((GetComponent<RectTransform>().rect.width / 2f), 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            MySceneManager.Instance.finalScore = MySceneManager.Instance.score;
            MySceneManager.Instance.score = 0;
            MySceneManager.Instance.coins = 0;
            MySceneManager.Instance.multiplier = 0;
            //Physics.gravity = new Vector3(0, -50, 0);
            Physics2D.gravity = new Vector2(0, -50f);
            other.gameObject.GetComponent<MainMenu>().Menuetwo();
        }
        else
        {
            Vector2 looping = GameObject.Find("Spawn Objects").GetComponent<RectTransform>().position;
            other.gameObject.transform.position = new Vector2(looping.x + other.gameObject.GetComponent<Transform>().localScale.x / 2f, transform.position.y);
        }
    }


}
