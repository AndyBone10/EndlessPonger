using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public bool gameOver;
	private float timeLeft;

	public AudioSource sonarLow,sonarMedium,sonarHigh,deathSound;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {

	

		if (PlayerPrefs.GetInt ("Muted") == 0) {
			sonarLow.mute = !sonarLow.mute;
			sonarMedium.mute = !sonarMedium.mute;
			sonarHigh.mute = !sonarHigh.mute;
			deathSound.mute = !deathSound.mute;

		}
		gameOver = false;
	}
		

	public void GameOver(){
		gameOver = true;
		UIManager.instance.GameOver ();
	}
}
