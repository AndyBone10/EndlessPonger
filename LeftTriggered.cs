using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTriggered : MonoBehaviour {

	public GameObject obstacleController;
	public GameObject rightTrigger;
	public AudioSource sonarMedium;

	void Start(){
		this.gameObject.SetActive (false);	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Ball") {
			sonarMedium.Play ();
			ScoreManager.instance.incrementScore ();
			ScoreManager.instance.setHighScore ();

			rightTrigger.SetActive (true);
			this.gameObject.SetActive (false);
			obstacleController.GetComponent<ObstacleController> ().stopped = false;
		}
	}
}
