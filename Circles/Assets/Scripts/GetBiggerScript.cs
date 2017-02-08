using UnityEngine;
using System.Collections;

public class GetBiggerScript : MonoBehaviour {

	// game objects
	public GameObject gray;
	public GameObject green;
	public GameObject theVoid;

	// is there a hit? hmmm
	public bool hit = false;

	// sizes and modifiers
	public float xScale;
	public float yScale;
	public float zScale;
	public float growMod;
	public float radius;

	// Use this for initialization
	void Start () {

		gray = GameObject.FindGameObjectWithTag ("Gray");
		green = GameObject.FindGameObjectWithTag ("Green");
		theVoid = GameObject.FindGameObjectWithTag ("The Void");

	
	}
	
	// Update is called once per frame
	void Update () {

		xScale = this.transform.localScale.x;
		yScale = this.transform.localScale.y;
		zScale = this.transform.localScale.y;

		if (Vector3.Distance(gray.transform.position, green.transform.position) < radius){
			Debug.Log ("this is working");
			GetBigger (gray);
			GetBigger (green);
		}
	}

	void GetBigger (GameObject obj){

		obj.transform.localScale = new Vector3 ((xScale + growMod), (yScale + growMod), (zScale + growMod));
	
	}
}
