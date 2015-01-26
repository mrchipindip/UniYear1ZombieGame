using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour {
	
	public int damage = 1;
	public string damageTag = "";
	public string damageTag2 = "";
	public string damageTag3 = "";
	public string damageTag4 = "";
	
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag (damageTag)) {
			other.SendMessage ("TakeDamage", damage);
			Debug.Log ("message sent");
		} else if (other.CompareTag (damageTag2)) {
			other.SendMessage ("TakeDamage", damage);
		} else if (other.CompareTag (damageTag3)) {
			other.SendMessage ("TakeDamage", damage);
		} else if (other.CompareTag (damageTag4)) {
			other.SendMessage ("TakeDamage", damage);
		}
		gameObject.SetActive( false);
	}
	
}
