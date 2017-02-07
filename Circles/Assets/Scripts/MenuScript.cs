using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public Button startText;

	// Use this for initialization
	void Start () {

		startText = startText.GetComponent<Button> ();
		
	}

	public void StartLevel(){

		SceneManager.LoadScene (1);

	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
