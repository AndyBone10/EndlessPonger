using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

	public bool up, down, stopped;
	private float spaceCount;
	private GameObject theBall;
	private BallController theBallController;
	public GameObject instructionsPanel;
	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt ("FirstTimePlayer") == 1) {
			instructionsPanel.SetActive (false);
		}


		theBall = GameObject.Find ("Ball");
		theBallController = theBall.GetComponent<BallController> ();
		spaceCount = 0.0f;
		up = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.gameOver == false) {
			if (theBallController.started) {
				if (this.transform.position.y >= 9.6) {
					down = true;
					up = false;
				} else if (this.transform.position.y <= -11) {
					up = true;
					down = false;
				}

				if (Input.GetKeyDown ("space")) {
					spaceCount += 1.0f;
					if (spaceCount <= 1.0f) {
						instructionsPanel.SetActive (false);
						GameObject.Find ("TapToStartText").GetComponent<Animator> ().Play ("TextDown");
					}
					if (spaceCount > 1.0f) {
						stopped = true;
					}
				}
		
				if (up && stopped == false) {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + 0.30f, this.transform.position.z);
				} else if (down && stopped == false) {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y - 0.30f, this.transform.position.z);
				}
			}
		}
	}
}
