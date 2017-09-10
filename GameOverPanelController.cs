using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanelController : MonoBehaviour {

	public AudioSource buttonPressedAudio;

	void Update(){
		if(this.gameObject.activeSelf == true){
			if (Input.GetKeyDown ("space")) {
				UIManager.instance.Reset();
			}
		}
	}


	public void twitterPress(){
		buttonPressedAudio.Play ();
		//Application.OpenURL ("https://twitter.com/AndyBone10?lang=en");
		Application.ExternalEval("window.open(\"https://twitter.com/AndyBone10?lang=en\")");
	}

	public void tumblrPress(){
		buttonPressedAudio.Play ();
		//Application.OpenURL ("https://andybones.tumblr.com/");
		Application.ExternalEval("window.open(\"https://andybones.tumblr.com/\")");

	}

}
