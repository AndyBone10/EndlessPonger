using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleController : MonoBehaviour {

	private Vector3 targetPosition;
	private GameObject ball;
	public float paddleSpeed;
	public AudioSource sonarLow;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.gameOver == false) {
			if (ball.transform.position.x < 0) {
				targetPosition = new Vector3 (this.transform.position.x, ball.transform.position.y, this.transform.position.z);
				this.transform.localPosition = Vector3.Lerp (this.transform.localPosition, targetPosition, Time.deltaTime * paddleSpeed);
			}
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Ball")
		{
			sonarLow.Play ();
			if (col.gameObject.GetComponent<BallController> ().velocityLocked == false) {
				col.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (col.gameObject.GetComponent<Rigidbody> ().velocity.x, col.gameObject.GetComponent<Rigidbody> ().velocity.y, 0.0f) * 1.05f;
			}
		}
	}
}
