using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBall : MonoBehaviour {

	public AudioSource deathSound;
	private BallController theBallController;

	void Start(){
		theBallController = GameObject.Find ("Ball").GetComponent<BallController> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Ball") {
			Instantiate (theBallController.deathExplosion, theBallController.transform.position, theBallController.transform.rotation);
			deathSound.Play ();
			ScoreManager.instance.setHighScore ();
			Destroy (other.gameObject);
			GameManager.instance.GameOver ();
		}
	}
}
