﻿using UnityEngine;
using System.Collections;

public class Bullet2D : MonoBehaviour {
	public float speed = 5.0f;
	public float destroyTime = 0.7f;

	// Use this for initialization
	void Start () {
		Invoke ("Die", destroyTime);
	
	}
	void Die(){
				Destroy (gameObject);
		}
	void OnDestroy(){
				CancelInvoke ("Die");
		}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = transform.up * speed;
	}
}
