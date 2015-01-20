﻿using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour {

	private int health;
	private int score;
	private int blueKey;
	private int pinkKey;
	private string gameInfo = "";
	private Rect boxRect = new Rect( 10, 10, 300, 50 );
	private Rect pauseRect = new Rect (10, 100, 300, 50);
	private bool gamePaused = false;

	void Update() {
		if (Input.GetKeyUp (KeyCode.Escape)) {
						gamePaused = !gamePaused;

						if (gamePaused) {
								Time.timeScale = 0.0000001f;
						} else {
								Time.timeScale = 1.0f;
						}
				}

		}

	void OnEnable() {
		PlayerBehaviour.onUpdateHealth += HandleonUpdateHealth;
		AddScore.onSendScore += OnSendScore;
		PinkKeys.onSendPinkKey += onSendPinkKey;
		}

	void OnDisable() {
		PlayerBehaviour.onUpdateHealth -= HandleonUpdateHealth;
		AddScore.onSendScore -= OnSendScore;
		PinkKeys.onSendPinkKey += onSendPinkKey;
		}

	void Start() {
				UpdateUI ();
		}
	
	void HandleonUpdateHealth (int newHealth)
	{
		health = newHealth;
		UpdateUI ();
	}

	void onSendPinkKey(int thePinkKey) {
		pinkKey += thePinkKey;
		UpdateUI ();

		}

	void OnSendScore(int theScore) {
				score += theScore;
				UpdateUI ();
		}

	void UpdateUI () {
		gameInfo = "Score: " + score.ToString () + "\nHealth: " + health + "\nPink Keys: " + pinkKey.ToString ();
	}
	void OnGUI() {
				GUI.Box (boxRect, gameInfo);

		if(gamePaused) {
			GUI.Box (pauseRect, "Game Paused");
		}
}
}