using UnityEngine;
using System.Collections;

public class DoorBehaviour : MonoBehaviour {

	public int health = 1;
	// Use this for initialization
	void Start () {
	
	}

	public void TakeDamage(int damage) {
		health -= damage;
		
		if( health <=0){
			Destroy(gameObject);
			GetComponent<PinkKeys>().DoMinusPinkKey();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
