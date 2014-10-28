using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float destroyTime=0.7f;
	public Animator anim;
	// Use this for initialization
	void OnEnable () {
		Invoke ("Die", destroyTime);
		anim.Play ("Explosion");
	
	}
	
	// Update is called once per frame
	void Die () {
		anim.StopPlayback();
		gameObject.SetActive (false);
	
	}
}
