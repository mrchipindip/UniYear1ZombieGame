using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Rigidbody2D))]
public class TopDownCharacterController2D : MonoBehaviour {
	public float speed = 5.0f;
	private bool powerUpOn = false;
	public float powerUpTime = 5.0f;
	// Use this for initialization
	void Start () {

	
	}
	public void PowerUp()
	{
		powerUpOn = true;
		powerUpTime = 5.0f;
		}
	void OnGUI()
	{
		if (powerUpOn == true) {
			GUI.Box(new Rect(Screen.width - 100,0,100,50), "Power Up:" + "\n\nSpeed: " + powerUpTime.ToString("0"));
				}
		}
	// Update is called once per frame
	void FixedUpdate () {

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		rigidbody2D.velocity = new Vector2 (x, y) * speed;
		rigidbody2D.angularVelocity = 0.0f;

		if(powerUpOn == true) {
			speed = 6;
			Debug.Log("speed changed");
			powerUpTime -= Time.deltaTime;
			if (powerUpTime <= 0 ){
				powerUpTime = 0;
				powerUpOn = false;
				speed = 3.5f;
			}
			
		}

	
	}
}
