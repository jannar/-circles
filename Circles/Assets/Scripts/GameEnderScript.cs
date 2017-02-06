using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// finish this later!

public class GameEnderScript : MonoBehaviour {

	public float radius;

	GameObject fakeSun;

	// Use this for initialization
	void Start () {

		fakeSun = GameObject.FindGameObjectWithTag ("The Void");

	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (fakeSun.transform.position, transform.position) < radius) {
			if (gameObject.transform.localScale.x <= 1) {
				Destroy (gameObject);
			}
		}
		
	}
}
