﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.gameObject.GetComponent<playerBox>().score += 40;
            MySceneManager.Instance.multiplier += .1f;
            Destroy(gameObject);
            
        }
    }


}