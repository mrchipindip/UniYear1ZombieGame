using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PoolManager : MonoBehaviour {
	public static PoolManager current;

	public string[] names;
	public GameObject[] pooledObjects;
	public int[] poolAmounts;

	private Hashtable mainPool = new Hashtable();
	private List<GameObject> tempList;


	// Use this for initialization
	void Awake() {
		current = this;
	}

	void Start () {
		tempList = new List<GameObject> ();

		for( int i = 0; i < names.Length; i++ ) {
			List<GameObject> objList = new List<GameObject>();

			for(int j = 0; j< poolAmounts[i]; j++) {
				GameObject obj = (GameObject)Instantiate( pooledObjects[i] );
				obj.SetActive(false);
				objList.Add(obj);
			}

			mainPool.Add(names[i], objList);
		}
	}

	public GameObject GetPooledObject( string name) {
		if(mainPool.ContainsKey(name)){
			tempList = mainPool[ name ]as List<GameObject>;

			for(int i = 0; i < tempList.Count; i++){
				if(tempList[i] != null) {
					if( !tempList[i].activeInHierarchy) {
						return tempList[i];
					}
				}
			}
		}
		return null;
	}
	

	//global reset of the pool can be called from anywhere
	public void ResetPool () {
		for(int i = 0; i < tempList.Count; i++ ){
			if(tempList[i] != null) {
				if(tempList[i].activeInHierarchy) {
					tempList[i].SetActive(false);
				}
			}
		}
	}
}
