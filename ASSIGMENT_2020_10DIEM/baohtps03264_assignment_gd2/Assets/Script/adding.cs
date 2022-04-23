using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adding : MonoBehaviour {

	// Use this for initialization

	public Text scoretext;
	int score=0;

	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateScore(){

		score++;

		scoretext.text = " Score:" + score;

	}
}
