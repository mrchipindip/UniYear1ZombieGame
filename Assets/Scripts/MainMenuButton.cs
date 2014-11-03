using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour {
	
	public string levelName = "Main Menu Scene";
	
	void OnMouseUp () {
		Application.LoadLevel (levelName);
	}
}
