using UnityEngine;
using System.Collections;

public class PinkKeys : MonoBehaviour {

	public delegate void SendPinkKey( int pinkKey );
	public static event SendPinkKey onSendPinkKey;
	public int pinkKey = 1;
	public int minusPinkKey = -1;
	
	public void DoPinkKey() {
		if (onSendPinkKey != null)
			onSendPinkKey (pinkKey);
	}

	public void DoMinusPinkKey () {
				if (onSendPinkKey != null)
				onSendPinkKey (minusPinkKey);
		}
	}