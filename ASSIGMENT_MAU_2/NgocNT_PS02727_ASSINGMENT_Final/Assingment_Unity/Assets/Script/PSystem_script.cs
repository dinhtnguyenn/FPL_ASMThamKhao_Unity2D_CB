using UnityEngine;
using System.Collections;

public class PSystem_script : MonoBehaviour {

	void Start () 
	{
		Destroy (transform.root.gameObject, 0.5f);
	}

	void Update()
	{	
		gameObject.transform.Translate(Vector3.up * Time.deltaTime * 10);
	}

}
