using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public float fireTime = 0.5f;

	private bool isFiring = false;

	void SetFiring(){
				isFiring = false;
		}

	void Fire(){
		isFiring = true;
		Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);


		print ("!!");
		//\\if(audio){
		//\\	audio.Play ();
		////}
		Invoke ("SetFiring",fireTime);
	}


	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton (0)){
			if(!isFiring){
				Fire();
			}
		}
	}
}	