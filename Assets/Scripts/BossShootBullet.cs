using UnityEngine;
using System.Collections;

public class BossShootBullet : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public Transform bulletSpawn2;
	public Transform bulletSpawn3;
	public Transform bulletSpawn4;
	public Transform bulletSpawn5;
	public Transform bulletSpawn6;
	public Transform bulletSpawn7;
	public Transform bulletSpawn8;
	public Transform bulletSpawnMode2Spawner;
	public Transform bulletSpawnMode2Spawner2;
	public Transform bulletSpawnMode2Spawner3;
	public Transform bulletSpawnMode2Spawner4;
	public Transform bulletSpawnMode2Spawner5;
	public Transform bulletSpawnMode2Spawner6;
	public Transform bulletSpawnMode2Spawner7;
	public Transform bulletSpawnMode2Spawner8;
	public Transform bulletSpawnMode2Spawner9;
	public Transform bulletSpawnMode2Spawner10;
	public Transform bulletSpawnMode2Spawner11;
	public Transform bulletSpawnMode2Spawner12;
	public GameObject Trigger;



	public float stateTimer = 1222222.0f;
	public float fireTime = 0.3f;
	public float fireTime2 = 0.4f;
	private bool isFiring = false;
	private int fireType = 1;
	private bool surprise = false;

	void SetFiring(){
		isFiring = false;
	}

	void Fire(){
		isFiring = true;
		Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		Instantiate (bulletPrefab, bulletSpawn2.position, bulletSpawn2.rotation);
		Instantiate (bulletPrefab, bulletSpawn3.position, bulletSpawn3.rotation);
		Instantiate (bulletPrefab, bulletSpawn4.position, bulletSpawn4.rotation);
		Instantiate (bulletPrefab, bulletSpawn5.position, bulletSpawn5.rotation);
		Instantiate (bulletPrefab, bulletSpawn6.position, bulletSpawn6.rotation);
		Instantiate (bulletPrefab, bulletSpawn7.position, bulletSpawn7.rotation);
		Instantiate (bulletPrefab, bulletSpawn8.position, bulletSpawn8.rotation);

		
		
		print ("!!");
		//\\if(audio){
		//\\	audio.Play ();
		////}
		Invoke ("SetFiring",fireTime);
	}

	void Fire2(){
		isFiring = true;
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner.position, bulletSpawnMode2Spawner.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner2.position, bulletSpawnMode2Spawner2.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner3.position, bulletSpawnMode2Spawner3.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner4.position, bulletSpawnMode2Spawner4.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner5.position, bulletSpawnMode2Spawner5.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner6.position, bulletSpawnMode2Spawner6.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner7.position, bulletSpawnMode2Spawner7.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner8.position, bulletSpawnMode2Spawner8.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner9.position, bulletSpawnMode2Spawner9.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner10.position, bulletSpawnMode2Spawner10.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner11.position, bulletSpawnMode2Spawner11.rotation);
		Instantiate (bulletPrefab, bulletSpawnMode2Spawner12.position, bulletSpawnMode2Spawner12.rotation);

		print ("!!");
		//\\if(audio){
		//\\	audio.Play ();
		////}
		Invoke ("SetFiring",fireTime2);
	}


	void Start () {
	
	}
	void audioGo() {
		if (surprise == false) {
			audio.Play();
			Debug.Log ("played");
			surprise = true;
				}
		
		}
	
	// Update is called once per frame
	void Update () {
		stateTimer -= Time.deltaTime;

		if(isFiring != true){
			if (fireType ==1){
				Fire ();

				Debug.Log (stateTimer.ToString());
				if(stateTimer <= -5.0){
					stateTimer = 0.0f;
					fireType = 2;
					Debug.Log ("Changed");
				}

			} else if (fireType == 2){
				if (Trigger != null)
				{
					Destroy (Trigger);
				}
				Fire2();
				Debug.Log (stateTimer.ToString());
				if(stateTimer <= -2.0){
					stateTimer = 0.0f;
					fireType = 1;
					Debug.Log ("Changed");
				}
			}

		}
	}
}
