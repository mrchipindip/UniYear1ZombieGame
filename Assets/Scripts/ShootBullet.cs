using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public Transform bulletSpawn2;

	public float fireTime = 0.3f;
	public float powerUpTime = 5.0f;
	private bool powerUpOn = false;
	private bool isFiring = false;

	void SetFiring(){
				isFiring = false;
		}

	void Fire(){
		isFiring = true;
		Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		Instantiate (bulletPrefab, bulletSpawn2.position, bulletSpawn2.rotation);



		print ("!!");
		//\\if(audio){
		//\\	audio.Play ();
		////}
		Invoke ("SetFiring",fireTime);
	}
	public void PowerUp()
	{
		powerUpTime = 5.0f;
		powerUpOn = true;
		Debug.Log ("function called");
	}

	void OnGUI()
	{
		if (powerUpOn == true) {
			GUI.Box(new Rect(Screen.width - 100,0,100,50), "Power Up:" + "\nFire Rate: " + powerUpTime.ToString("0"));
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton (0)){
			if(!isFiring){
				Fire();
			}
		}

		if(powerUpOn == true) {
			fireTime = 0.15f;
			powerUpTime -= Time.deltaTime;
			if (powerUpTime <= 0 ){
				powerUpTime = 0;
				powerUpOn = false;
				fireTime = 0.3f;
			}
			
		}

	}
}	