using UnityEngine;
using System.Collections;

public class GetBiggerScript : MonoBehaviour {

	public GameObject gray;
	public GameObject green;
	public bool hit = false;
	public float xScale;
	public float yScale;
	public float zScale;

	// Use this for initialization
	void Start () {

		gray = GameObject.FindGameObjectWithTag ("Gray");
		green = GameObject.FindGameObjectWithTag ("Green");
	
	}
	
	// Update is called once per frame
	void Update () {

		xScale = this.transform.localScale.x;
		yScale = this.transform.localScale.y;
		zScale = this.transform.localScale.y;

	}

	void OnCollisionEnter2D(Collider2D col){

		col.transform.localScale = new Vector3 (((xScale - .1f)),
			(yScale - .1f), (zScale - .1f));
	}
}
