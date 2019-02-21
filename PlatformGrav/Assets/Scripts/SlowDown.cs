using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : PowerUp {
	
	// Update is called once per frame
	public override void Update () {
        base.Update();

        if (isActive)
        {
            Move.SPEED = 8f;
            return;
        }

        if (duration < 0)
        {
            Move.SPEED = 20f;
            Destroy(gameObject);
        }
      

    }
}
