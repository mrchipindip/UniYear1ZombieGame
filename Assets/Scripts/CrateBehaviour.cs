using UnityEngine;
using System.Collections;

public class CrateBehaviour : MonoBehaviour {
	public int health = 10;
	
	public void TakeDamage (int damage)
	{
		health -= damage;
		audio.Play ();

		if (health <= 0) 
		{

			Destroy(gameObject);
		}
	}
}
