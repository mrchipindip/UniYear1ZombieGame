using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public GameObject objectPrefab;
	public GameObject objectPrefab2;
	private Transform mTransform;

	void Start () {
		mTransform = transform;
	}
	
	// Update is called once per frame
	public void Spawn () {
		Instantiate (objectPrefab, mTransform.position, mTransform.rotation);
		if (objectPrefab2 != null) {
						Instantiate (objectPrefab2, mTransform.position, mTransform.rotation);
				}
		}
}
