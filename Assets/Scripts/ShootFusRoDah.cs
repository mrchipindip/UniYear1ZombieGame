using UnityEngine;
using System.Collections;

public class ShootFusRoDah : MonoBehaviour {
	public GameObject FusRoDahPrefab;
	public Transform FusRoDahSpawn;
	public float fireTime = 0.5f;

	private bool onCooldown = true;
	public float cooldownTime = 5.0f;
	private bool isFiring = false;
	private string printCooldown = "";
	
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
	void OnGUI()
	{

		GUI.Box(new Rect(0,75,200,50), "Special Cooldown:" + "\n" + printCooldown);

	}
	// Update is called once per frame
	void Update () {
		if (onCooldown == true){

				cooldownTime -= Time.deltaTime;
			if (cooldownTime <= 0 ){
				cooldownTime = 0;
				onCooldown = false;

				}
		}
		else if(Input.GetMouseButtonDown (2)){
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
		if (cooldownTime == 0) {
						printCooldown = "Ready";
				} else {
						printCooldown = cooldownTime.ToString ("0");
				}
	}

	void DelayedShot() {
		Fire();
		onCooldown = true;
		cooldownTime = 5.0f;
	}
}	