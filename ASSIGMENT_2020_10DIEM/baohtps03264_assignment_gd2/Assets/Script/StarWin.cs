using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWin : MonoBehaviour {
	[SerializeField]
	private GameObject victoryPanel;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D (Collider2D other){
		if(other.gameObject.tag == "Player"){
			Time.timeScale = 0;
			victoryPanel.SetActive(true);
			GameObject.Find ("Main Camera").GetComponent<AudioSource> ().Pause ();
			gameObject.GetComponentInChildren<AudioSource>().Play();
		}
	}
}
