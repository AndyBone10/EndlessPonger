using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTriggered : MonoBehaviour {

	public GameObject obstacleController;
	public GameObject leftTrigger;
	public AudioSource sonarMedium;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Ball") {
			sonarMedium.Play ();
			ScoreManager.instance.incrementScore ();
			ScoreManager.instance.setHighScore ();

			leftTrigger.SetActive (true);
			this.gameObject.SetActive (false);
			obstacleController.GetComponent<ObstacleController> ().stopped = false;
		}
	}
}
