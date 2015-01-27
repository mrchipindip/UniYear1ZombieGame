using UnityEngine;
using System.Collections;

public class FirstBossEnabler : MonoBehaviour {
	public GameObject spawner;
	public GameObject spawner2;
	public GameObject spawner3;
	public GameObject spawner4;
	public GameObject spawner5;
	public GameObject spawner6;

	public GameObject audioCaller;
	public int audioTrack = 1;
	
	//void Start() {
	//	if (spawner == null)
	//	spawner = GameObject.FindWithTag("spawner");
	
	//Instantiate(spawnerPrefab, spawner.transform.position, spawner.transform.rotation) as GameObject;
	//}
	
	
	
	public void Enabler(int damage) {
		audioCaller.transform.SendMessage("AudioChange", audioTrack);
		if (damage > 0) {
			Debug.Log ("hello world");
			spawner.gameObject.SetActive(true);
			if (spawner2 != null)
			{
				spawner2.gameObject.SetActive(true);
			}
			if (spawner3 != null)
			{
				spawner3.gameObject.SetActive(true);
			}
			if (spawner4 != null)
			{
				spawner4.gameObject.SetActive(true);
			}
			if (spawner5 != null)
			{
				spawner5.gameObject.SetActive(true);
			}
			if (spawner6 != null)
			{
				spawner6.gameObject.SetActive(true);
			}
			Destroy (gameObject);
		}
	}
}
