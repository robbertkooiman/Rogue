using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Actor {
	
	override protected void Start() {
	}

	void GetHit(float amount) {
		base.Damage(amount);
		float hitDirection = 100f; // check from where the player hit the emeny
	}

	void Attack() {
		// do attack at player
	}

	override protected void Die(){
		base.Die();
		// remove enemy/show corpse
		// grant player coins/xp/whatever
	}
}
