using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public GameObject objectPrefab;
	private Transform mTransform;

	void Start () {
		mTransform = transform;
	}
	
	// Update is called once per frame
	public void Spawn () {
		Instantiate (objectPrefab, mTransform.position, mTransform.rotation);
		}
}
