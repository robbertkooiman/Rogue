using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Actor {

	private Rigidbody2D body;
	
	void Start() {
		body = GetComponent<Rigidbody2D>();
	}

	void GetHit(float amount) {
		base.damage(amount);
		float hitDirection = 100f; // check from where the player hit the emeny
		body.AddForce(new Vector2(hitDirection, 10f)); // make the enmey move back
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
