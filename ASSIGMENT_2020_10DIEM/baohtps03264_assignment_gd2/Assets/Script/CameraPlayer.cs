using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour {
	public Transform target;
	public float smoothing;
	Vector3 offSet;

	float lowY;
	float lowX;
	// Use this for initialization
	void Start () {
		offSet = transform.position - target.position;
		lowY = transform.position.y;
		lowX = transform.position.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 targetCamPos = target.position + offSet;

		transform.position = Vector3.Lerp (transform.position,targetCamPos,smoothing * Time.deltaTime);
		if(transform.position.y < lowY){
			transform.position = new Vector3(transform.position.x,lowY,transform.position.z);
		}
		if(transform.position.y > lowY){
			transform.position = new Vector3(transform.position.x,lowY,transform.position.z);
		}
		if (transform.position.x < lowX) {
			transform.position = new Vector3(lowX,transform.position.y,transform.position.z);
		}
	}
}
