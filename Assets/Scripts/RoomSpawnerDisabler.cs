using UnityEngine;
using System.Collections;

public class RoomSpawnerDisabler : MonoBehaviour {

	public GameObject spawner;
	public GameObject spawner2;
	public GameObject spawner3;
	public GameObject spawner4;
	public GameObject spawner5;

	public void Enabler(int damage) {
		if (damage > 0) {
			if (spawner != null)
			{
				if (GameObject.Find(spawner.name) != null)
				{
					Destroy (spawner);
				}
			}

			if (spawner2 != null)
			{
				if (GameObject.Find(spawner2.name) != null)
				{
					Destroy (spawner2);
				}
			}
			if (spawner3 != null)
			{
				if (GameObject.Find(spawner3.name) != null)
				{
					Destroy (spawner3);
				}
			}
			if (spawner4 != null)
			{
				if (GameObject.Find(spawner4.name) != null)
				{
					Destroy (spawner4);
				}
			}
			if (spawner5 != null)
			{
				if (GameObject.Find(spawner5.name) != null)
				{
					Destroy (spawner5);
				}
			}

			Destroy (gameObject);
		}
	}
}
