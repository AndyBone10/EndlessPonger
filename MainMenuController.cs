using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public UnityEngine.UI.Text highScoreText;
	public AudioSource buttonPressedAudio;
	public Sprite soundEnabledSprite, soundDisabledSprite;
	public UnityEngine.UI.Button soundButton;

	void Start(){

		if (!PlayerPrefs.HasKey ("FirstTimePlayer")) {
			PlayerPrefs.SetInt ("FirstTimePlayer", 0);
		} else {
			PlayerPrefs.SetInt ("FirstTimePlayer", 1);
		}



		if (!PlayerPrefs.HasKey("Muted")) {
			PlayerPrefs.SetInt ("Muted", 1);
		}
		if (PlayerPrefs.GetInt ("Muted") == 0) {
			soundButton.image.sprite = soundDisabledSprite;

		}

		if (PlayerPrefs.GetInt ("Muted") == 1) {
			soundButton.image.sprite = soundEnabledSprite;

		}

		highScoreText.text = PlayerPrefs.GetInt ("HighScore").ToString();
	}

	public void twitterPress(){
		Application.OpenURL ("https://twitter.com/AndyBone10?lang=en");
	}

	public void tumblrPress(){
		Application.OpenURL ("https://andybones.tumblr.com/");
	}

	public void playGame(){
		SceneManager.LoadScene ("Scene1");
	}

	public void soundPress(){
		if (PlayerPrefs.GetInt ("Muted") == 0) {
			soundButton.image.sprite = soundEnabledSprite;
			PlayerPrefs.SetInt ("Muted", 1);
		}
		else if(PlayerPrefs.GetInt ("Muted") == 1){
			soundButton.image.sprite = soundDisabledSprite;
			PlayerPrefs.SetInt ("Muted", 0);
		}

	}
}
