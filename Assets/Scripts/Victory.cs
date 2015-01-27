using UnityEngine;
using System.Collections;

public class Victory : MonoBehaviour {
	public string levelName = "Main Menu Scene";

	public void Enabler(int damage) {
		Application.LoadLevel (levelName);
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
