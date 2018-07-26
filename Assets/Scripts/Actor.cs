using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Collider2D))]
public class Actor : MonoBehaviour
{
	private bool alive = true;
    private float health = 100f;
    private string myName = "Actor";
	protected Collider2D collider;

	virtual protected void Start() {
		collider = GetComponent<Collider2D>();
	}

    virtual protected void Damage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            Die();
        }
    }

    virtual protected void Die()
    {
		alive = false;
		health = 0f;
    }
}
