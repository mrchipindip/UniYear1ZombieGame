using UnityEngine;
using System.Collections;

public class DoorBehaviour : MonoBehaviour {


	public delegate void SendPinkKey( int pinkKey );
	public static event SendPinkKey onSendPinkKey;
	public int pinkKey = 1;

	
	public void DoPinkKey() {
		if (onSendPinkKey != null)
			onSendPinkKey (pinkKey);
	}

	public int health = 1;
	// Use this for initialization
	void Start () {
	
	}

	public void TakeDamage(int damage) {
		health -= damage;
		
		if( health <=0){
			Destroy(gameObject);
			//can i send the spawner enables from here?

		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
