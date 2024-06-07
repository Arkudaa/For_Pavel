﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public int coins;

	

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
		
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {
			coins++;
			HUD.UpdateCoinCount(coins);
			Destroy(collided.gameObject);
		}


		if (collided.gameObject.name =="Powerup1")
		{
			Destroy(collided.gameObject);
			Abilities.doubleJumpEnabled = true;
		}

        if (collided.gameObject.name == "Powerup2")
        {
            Destroy(collided.gameObject);
            Abilities.spinAttackEnabled = true;
        }

    }
}