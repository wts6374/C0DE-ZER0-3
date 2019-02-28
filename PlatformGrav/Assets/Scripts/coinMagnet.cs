using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMagnet : PowerUp {
	// Use this for initialization
	RaycastHit hit;
	public GameObject player;

	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
		player = GameObject.Find("Player");
		Debug.Log (this.isActive);
		if (this.isActive == true) {
			Debug.Log ("sdfd");
			if (Physics.SphereCast(player.transform.position, 10, Vector3.right, out hit, 10))
			{
				if (hit.transform.name.Contains("Coin"))
				{
					Destroy(hit.transform.gameObject);
					Debug.Log("coin");
				}
			}
		}
	}

	public void SetActive()
	{
		if (MySceneManager.Instance.coins >= 20)
		{
			MySceneManager.Instance.coins -= 20;
			MySceneManager.Instance.multiplier -= (.1f * 20.0f);
			duration = 5;
			isActive = !isActive;
		}
	}
}
