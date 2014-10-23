using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour {
	public GameObject Spawner;

	public float MinX = -23.8f;
	public float MaxX = 23.8f;
	public float MinY = -23.8f;
	public float MaxY = 23.8f;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		//float x = Random.Range (MinX, MaxX);
		//float y = Random.Range (MinY, MaxY);

		//Instantiate(Spawner, new Vector3 (x,y,0), Quaternion.identity);
	}
}
