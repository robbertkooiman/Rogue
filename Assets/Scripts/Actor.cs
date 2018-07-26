using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
	private bool alive = true;
    private float health = 100f;
    private string myName = "Actor";

    public void damage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            die();
        }
    }

    private void die()
    {
		alive = false;
    }
}
