using UnityEngine;
using System.Collections;

public class SpawnerBehaviour : MonoBehaviour {
	public int health = 20;

	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0) 
		{
			Destroy(gameObject);
		}
	}
}
