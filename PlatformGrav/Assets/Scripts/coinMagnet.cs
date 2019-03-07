using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMagnet : PowerUp {
	GameObject player;
	RaycastHit2D[] hit;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (isActive == true) {
			
			hit = Physics2D.CircleCastAll(new Vector2(player.transform.position.x, player.transform.position.y), 10, Vector2.right, 10);

			for (int i = 0; i < hit.Length; i++) {
				if (hit [i].transform.tag == "Coin" && hit[i] != null) {
					Debug.Log ("coin");
					MySceneManager.Instance.score += 10;
					MySceneManager.Instance.multiplier += .1f;
					MySceneManager.Instance.coins++;
					Destroy (hit [i].transform.gameObject);

				}
			}
			}
				
		}	
	}

