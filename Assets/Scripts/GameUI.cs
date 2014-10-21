﻿using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour {

	private int health;
	private int score;
	private string gameInfo = "";
	private Rect boxRect = new Rect( 10, 10, 300, 50 );

	void OnEnable() {
		PlayerBehaviour.onUpdateHealth += HandleonUpdateHealth;
		AddScore.onSendScore += OnSendScore;
		}

	void OnDisable() {
		PlayerBehaviour.onUpdateHealth -= HandleonUpdateHealth;
		AddScore.onSendScore -= OnSendScore;
		}

	void Start() {
				UpdateUI ();
		}
	
	void HandleonUpdateHealth (int newHealth)
	{
		health = newHealth;
		UpdateUI ();
	}

	void OnSendScore(int theScore) {
				score += theScore;
				UpdateUI ();
		}

	void UpdateUI () {
		gameInfo = "Score: " + score.ToString () + "\nHealth: " + health;
	}
	void OnGUI() {
				GUI.Box (boxRect, gameInfo);
		}
}
