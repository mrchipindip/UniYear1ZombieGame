using UnityEngine;
using System.Collections;

public class ShootFusRoDah : MonoBehaviour {
	public GameObject FusRoDahPrefab;
	public Transform FusRoDahSpawn;
	public float fireTime = 0.5f;
	private bool executing = false;
	
	private bool isFiring = false;
	
	void SetFiring(){
		isFiring = false;
	}
	
	void Fire(){
		isFiring = true;
		Instantiate (FusRoDahPrefab, FusRoDahSpawn.position, FusRoDahSpawn.rotation);
		
		
		print ("!!");

		Invoke ("SetFiring",fireTime);
	}
	
	//IEnumerator ACoroutine() {
	//	executing = true;
		//yield WaitForSeconds(2);

	//}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown (2)){
			audio.Play ();
			if(!isFiring){
				//if(audio){
					//audio.Play ();
				//}
				audio.Play ();
				Invoke("DelayedShot", 1.0f );

					//StartCoroutine(ACoroutine());
						//executing = false;
					//StartCoroutine();
					//yield return new WaitForSeconds(4);



			}
		}
	}

	void DelayedShot() {
		Fire();
	}
}	