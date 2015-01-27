using UnityEngine;
using System.Collections;

public class HardMode : MonoBehaviour {
	
	public string levelName = "ZombieShooterHArd";
	
	void OnMouseUp () {
		Application.LoadLevel (levelName);
		Debug.Log ("called");
	}
}
