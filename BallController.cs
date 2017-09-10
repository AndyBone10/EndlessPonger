using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	public float ballSpeed = 18;
	private float sx;
	private float sy;
	public bool started;
	public bool velocityLocked;
	Rigidbody theRigidbody;

	public GameObject deathExplosion;

	// Use this for initialization
	void Start () {
		theRigidbody = GetComponent<Rigidbody> ();
	}

	void Update(){
		if (Input.GetKeyDown ("space") && started == false) {
			started = true;
			setBallValues ();
		}
		if (theRigidbody.velocity.x > 18.0f || theRigidbody.velocity.y > 18.0f) {
			GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude (new Vector3(GetComponent<Rigidbody> ().velocity.x, GetComponent<Rigidbody> ().velocity.y, 0.0f), 27);
			velocityLocked = true;
		}

	
	}

	private void setBallValues(){
		sx = Random.Range (0, 2) == 0 ? -1 : -1;
		sy = Random.Range (0, 2) == 0 ? -1 : 1;
		GetComponent<Rigidbody> ().velocity = new Vector3 (ballSpeed * sx, ballSpeed * sy, 0);
	}

		
}
