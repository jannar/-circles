using UnityEngine;
using System.Collections;

public class GetBiggerScript : MonoBehaviour {

	public GameObject gray;
	public GameObject green;
	public bool hit = false;
	public float xScale;
	public float yScale;
	public float zScale;
	public float growMod;
	public float radius;

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

		if (Vector3.Distance(gray.transform.position, green.transform.position) < radius){
			GetBigger (gray);
			GetBigger (green);
		}

	}

	void GetBigger (GameObject obj){

		obj.transform.localScale = new Vector3 ((xScale + growMod), (yScale + growMod), (zScale + growMod));
	
	}

//	void OnTriggerEnter2D(Collider2D col){
//
//		if ((this.gameObject.CompareTag("Green") && col.gameObject.CompareTag("Gray"))
//			|| (this.gameObject.CompareTag("Gray") && col.gameObject.CompareTag ("Green"))) {
//			Debug.Log ("hit!");
//			//this.hit = true;
////			col.transform.localScale = new Vector3 (((xScale + .1f)),
////				(yScale + .1f), (zScale + .1f) * Time.deltaTime);
//		}
//	}
}
