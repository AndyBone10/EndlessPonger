using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTriggerController : MonoBehaviour {

	public AudioSource sonarMedium;

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter(Collider other){
		if (other.tag == "Ball") {
			sonarMedium.Play ();
		}
	}
}
