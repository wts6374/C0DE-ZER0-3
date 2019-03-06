using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour {

    public float duration;
    public bool isActive;
    

    // Use this for initialization
    public virtual void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (isActive)
        {
            duration -= Time.deltaTime;
            if (duration < 0)
            {
                isActive = false;
                
            }
        }
    }


}
