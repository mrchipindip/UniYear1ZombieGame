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
		//yield WaitForSeconds(4);

	//}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton (1)){
			if(!isFiring){

					if(audio){
						audio.Play ();
					}
					//StartCoroutine(ACoroutine());
						//executing = false;
					//StartCoroutine();
					//yield return new WaitForSeconds(4);


				Fire();
			}
		}
	}
}	