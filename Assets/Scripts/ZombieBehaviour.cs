﻿using UnityEngine;
using System.Collections;

public class ZombieBehaviour : MonoBehaviour {
	private Transform player;
	public int health = 10;
	public int damage = 15;
	public GameObject explosionPrefab;
	public float adjustExplosionAngle = 0.0f;
	public GameObject enabledObject;

	public void TakeDamage(int damage) {
		health -= damage;
		Debug.Log (health.ToString ());
		if( health <=0){

			Quaternion newRot = Quaternion.Euler (transform.eulerAngles.x,transform.eulerAngles.y,transform.eulerAngles.z+adjustExplosionAngle);
			Instantiate(explosionPrefab,transform.position,newRot);
			GetComponent<AddScore>().DoSendScore();
			if (enabledObject != null)
			{
				enabledObject.gameObject.SetActive(true);
			}
			Destroy(gameObject);
}
	}

	void Start() {
				if (GameObject.FindWithTag ("Player")) {
						player = GameObject.FindWithTag ("Player").transform;

						GetComponent<MoveTowardsObject> ().target = player;
						GetComponent<SmoothLookAtTarget2D> ().target = player;
				}
		}
	void OnCollisionEnter2D(Collision2D other) {

				if (other.gameObject.CompareTag ("Player")) {
			other.transform.SendMessage ("TakeDamage", damage);
			}
				
		}

	void FixedUpdate(){
				rigidbody2D.velocity = Vector2.zero;
				rigidbody2D.angularVelocity = 0.0f;
		}
}
