using UnityEngine;
using System.Collections;

public class MusicChanger : MonoBehaviour {
	public GameObject audioCaller;
	public int audioTrack = 1;
	// Use this for initialization
	void Start () {
	
	}
	public void Enabler(int damage) {
				audioCaller.transform.SendMessage ("AudioChange", audioTrack);
				if (damage > 0) {
					Destroy (gameObject);
				}

		}
	// Update is called once per frame
	void Update () {
	
	}
}
