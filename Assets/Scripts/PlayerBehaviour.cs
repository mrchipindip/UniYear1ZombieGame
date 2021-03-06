﻿using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	public delegate void UpdateHealth ( int newHealth );
	public static event UpdateHealth onUpdateHealth;
	public delegate void UpdatePinkKeys ( int newPinkKey );
	public static event UpdatePinkKeys onUpdatePinkKeys;
	public delegate void UpdateBlueKeys ( int newBlueKey );
	public static event UpdateBlueKeys onUpdateBlueKeys;

	public string levelName = "GameOverScene";
	private int damage = 2;
	public int health = 100;
	public int blueKey = 0;
	public int pinkKey = 0;
	public Transform walkingTransform;
	public int rapidFireDuration = 5;

	private int score;
	private Animator anim;
	private Animator walkingAnim;
	private AudioSource walkingSound;
	public GameObject audioCaller;
	public int audioTrack = 1;


	void Start () {
		audioCaller.transform.SendMessage("AudioChange", audioTrack);
		anim = GetComponent<Animator> ();
		walkingAnim = walkingTransform.GetComponent<Animator> ();
		walkingSound = walkingTransform.GetComponent<AudioSource> ();

		if (onUpdateHealth != null) {
						onUpdateHealth (health);
				}
		if (onUpdateBlueKeys != null) {
			onUpdateBlueKeys (blueKey);
		}
		if (onUpdatePinkKeys != null) {
			onUpdatePinkKeys (pinkKey);
		}
	}
	

	void Update () {
		if (Input.GetMouseButton (0)) {
						anim.SetBool ("isFiring", true);
				} else {
						anim.SetBool ("isFiring", false);
				}

		if (rigidbody2D.velocity != Vector2.zero) {
						walkingAnim.SetBool ("isWalking", true);

						if (!walkingSound.isPlaying) {
								walkingSound.Play ();
								walkingSound.loop = true;
						}

				} else {
			walkingAnim.SetBool( "isWalking", false );

			if(walkingSound.isPlaying ){
				walkingSound.Stop();
				walkingSound.loop = false;
			}
	}

				
}
	public void TakeDamage( int damage ) {
		health -= damage;

		if( onUpdateHealth != null )
			onUpdateHealth( health );

		if(health <=0 ) {
			Application.LoadLevel (levelName);
			Die();
		}
	}
	void Die (){

		}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Room1")) {
			other.transform.SendMessage("Enabler", damage);
				}
		}
	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.CompareTag ("BlueKey")) {
						other.transform.SendMessage ("TakeDamage", damage);
						blueKey += 1;
						if (onUpdateBlueKeys != null) {
								onUpdateBlueKeys (blueKey);
						}
						//if (other.gameObject.CompareName ("BlueKey")){

						//}
				} else if (other.gameObject.CompareTag ("PinkKey")) {
						other.transform.SendMessage ("TakeDamage", damage);
						pinkKey += 1;
						if (onUpdatePinkKeys != null) {
								onUpdatePinkKeys (pinkKey);
						}
				} else if (other.gameObject.CompareTag ("BlueDoors")) {
						if (blueKey > 0) {
								other.transform.SendMessage ("TakeDamage", damage);
								blueKey -= 1;
								if (onUpdateBlueKeys != null) {
										onUpdateBlueKeys (blueKey);
								}
				
						}
				} else if (other.gameObject.CompareTag ("PinkDoors")) {
						if (pinkKey > 0) {
								other.transform.SendMessage ("TakeDamage", damage);
								pinkKey -= 1;
								if (onUpdatePinkKeys != null) {
										onUpdatePinkKeys (pinkKey);
								}
						}
				} else if (other.gameObject.CompareTag ("Room1")) {
						other.transform.SendMessage ("Enabler", damage);
				} else if (other.gameObject.CompareTag ("Room2")) {
						other.transform.SendMessage ("Enabler", damage);
				} else if (other.gameObject.CompareTag ("HealthPickup")) {
						other.transform.SendMessage ("TakeDamage", damage);
						if (health >= 80) {
								health = 100;
						} else {
								health += 20;
						}
						if (onUpdateHealth != null) {
								onUpdateHealth (health);
						}
				} else if (other.gameObject.CompareTag ("SpeedPickup")) {
						TopDownCharacterController2D otherScript = GetComponent<TopDownCharacterController2D>();
						otherScript.PowerUp();
						other.transform.SendMessage ("TakeDamage", damage);
				} else if (other.gameObject.CompareTag ("FireRatePickup")) {
						ShootBullet otherScript = GetComponent<ShootBullet>();
						otherScript.PowerUp();
						other.transform.SendMessage ("TakeDamage", damage);
				}


	}



}
