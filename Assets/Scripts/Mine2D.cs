using UnityEngine;
using System.Collections;

public class Mine2D : MonoBehaviour {
	public float speed = 0.0f;
	public float destroyTime = 2.5f;
	
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