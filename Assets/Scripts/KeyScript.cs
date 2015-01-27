using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {
	public int health = 1;
	public GameObject enabledObject;
	// Use this for initialization
	void Start () {
		
	}
	
	public void TakeDamage(int damage) {
		health -= damage;
		
		if( health <=0){
			if (enabledObject != null)
			{
				enabledObject.gameObject.SetActive(true);
			}
			Destroy(gameObject);
			//GetComponent<PinkKeys>().DoPinkKey();
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
