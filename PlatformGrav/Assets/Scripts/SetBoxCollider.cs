using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBoxCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<BoxCollider2D>().size = new Vector2(GetComponent<RectTransform>().rect.width, GetComponent<RectTransform>().rect.height - 1);
        GetComponent<BoxCollider2D>().offset = new Vector2(1, -(GetComponent<RectTransform>().rect.height / 2f));
	}
}
