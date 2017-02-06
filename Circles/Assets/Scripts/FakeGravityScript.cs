using UnityEngine;
using System.Collections;

public class FakeGravityScript : MonoBehaviour {

	public GameObject fakeSun;
	public float gravitySpeed;
	public float originalGravitySpeed;
	PlayerMoveScript ps;

	// Use this for initialization
	void Start () {

		fakeSun = GameObject.Find ("Sphere");

		ps = this.gameObject.GetComponent <PlayerMoveScript> ();

		originalGravitySpeed = gravitySpeed;
	
	}

	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp (this.transform.position,
			fakeSun.transform.position, gravitySpeed);

	}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("The Void") == true) {
			if (ps.greenMove == true) {
				gravitySpeed *= .002f;
				ps.speed %= 2;
			} else {
				gravitySpeed = originalGravitySpeed;
			}

			if (ps.grayMove == true) {
				gravitySpeed *= .002f;
				ps.speed %= 2;
			} else {
				gravitySpeed = originalGravitySpeed;
			}
		}

	}
}
