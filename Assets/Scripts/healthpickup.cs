using UnityEngine;
using System.Collections;

public class healthpickup : MonoBehaviour {

	public int health = 1;
	
	public void TakeDamage (int damage)
	{
		health -= damage;
		
		if (health <= 0) 
		{
			Destroy(gameObject);
		}
	}
}
