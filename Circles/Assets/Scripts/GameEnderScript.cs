using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// finish this later!

public class GameEnderScript : MonoBehaviour {

	public float radius;

	GameObject fakeSun;
	GameObject goal;

	// Use this for initialization
	void Start () {

		fakeSun = GameObject.FindGameObjectWithTag ("The Void");
		goal = GameObject.FindGameObjectWithTag ("Finish");

	}

	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (fakeSun.transform.position, transform.position) < radius) {
			if (gameObject.transform.localScale.x <= 2.5) {
				Destroy (gameObject);
			}
		}

		if (Vector3.Distance (goal.transform.position, transform.position) < radius) {
			if ((this.gameObject.transform.localScale.x >= goal.transform.localScale.x) && (this.gameObject.transform.localScale.y >= goal.transform.localScale.y)) {
				Debug.Log ("you win yay" + " " + this.name);
				if (this.name.Contains ("Gray")) {
					SceneManager.LoadScene (2);
				} else if (this.name.Contains ("Green")) {
					SceneManager.LoadScene (3);
				}
			}
		}
		
	}
}
