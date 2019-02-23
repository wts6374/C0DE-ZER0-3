using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.gameObject.GetComponent<playerBox>().score += 40;
            MySceneManager.Instance.multiplier += .1f;
            MySceneManager.Instance.coins++;
            Debug.Log(gameObject.tag);
            if (gameObject.tag == "SlowAbility")
            {
                gameObject.GetComponent<SlowDown>().isActive = true;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                Destroy(gameObject);
            }
            
            
        }
    }


}
