using UnityEngine;
using System.Collections;

public class Backgroundmusic : MonoBehaviour {

	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;

	public void AudioChange(int audioToPlay){

		if (audioToPlay == 1) {
						audio2.Stop ();
						audio3.Stop ();
						audio1.Play ();
				} else if (audioToPlay == 2) {
						audio1.Stop();
						audio2.Play ();
				} else if (audioToPlay == 3) {
						audio1.Stop();
						audio3.Play();
				}

		}
	void Start () {
	
	}
	

	void Update () {
	
	}
}
