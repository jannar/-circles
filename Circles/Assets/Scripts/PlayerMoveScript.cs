using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {

	// speeds
	public float speed = 1;
	public float initialSpeed;
	public float finalSpeed;

	// player game objects
	public GameObject gray;
	public GameObject green;

	// inputs
	public KeyCode upKey = KeyCode.W;
	public KeyCode downKey = KeyCode.S;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode rightKey = KeyCode.D;

	// player move bools
	public bool grayMove = false;
	public bool greenMove = false;

	// variables for setting world bounds
	float minX, maxX, minY, maxY;
	float playerRadius;

	// Use this for initialization
	void Start () {

		CircleCollider2D playerCollider = this.GetComponent<CircleCollider2D> ();
		playerRadius = playerCollider.bounds.extents.x;

		// set the speeds
		initialSpeed = speed;

		// find the objects
		gray = GameObject.FindGameObjectWithTag ("Gray");
		green = GameObject.FindGameObjectWithTag ("Green");

		// set the min/max values for world bounds
		float camDistance = Vector3.Distance(this.transform.position, Camera.main.transform.position);
		Vector2 bottomCorner = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, camDistance));
		Vector2 topCorner = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, camDistance));

		minX = bottomCorner.x + playerRadius;
		maxX = topCorner.x - playerRadius;
		minY = bottomCorner.y + playerRadius;
		maxY = topCorner.y - playerRadius;
	
	}
	
	// Update is called once per frame
	void Update () {

		// FOR SETTING BOUNDARIES
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minX, maxX),
			Mathf.Clamp (transform.position.y, minY, maxY), transform.position.z);

		// MOVEMENT KEYS
		Move (Vector3.up, upKey);
		Move (Vector3.down, downKey);
		Move (Vector3.left, leftKey);
		Move (Vector3.right, rightKey);
	
	}

	void Move(Vector3 dir, KeyCode key){

		// GRAY MOVEMENT RULES
		if (this.gameObject == gray){
			if (Input.GetKey (key)) {
				transform.Translate (dir * (speed += 0.05f) * Time.deltaTime);
				grayMove = true;
			} else {
				grayMove = false;
			}
		}

		// GREEN MOVEMENT RULES
		if (this.gameObject == green){
			if (Input.GetKey (key)) {
				transform.Translate (dir * (speed += 0.025f) * Time.deltaTime);
				greenMove = true;
			} else {
				greenMove = false;
			}
		}

		// IF NOT MOVING, ADJUST SPEEDS ACCORDINGLY
		if (Input.GetKeyUp (key)) {
			if (this.gameObject == gray) {
				finalSpeed = 15;
				if (grayMove == false) {
					SlowSpeed (gray);
				}
			} else if (this.gameObject == green) {
				finalSpeed = 10;
				if (greenMove == false) {
					SlowSpeed (green);
				}
			}
		}
	}

	// self-explanatory
	void SlowSpeed(GameObject obj){

		this.speed = Mathf.Lerp (initialSpeed, finalSpeed, Time.deltaTime);

	}
}
