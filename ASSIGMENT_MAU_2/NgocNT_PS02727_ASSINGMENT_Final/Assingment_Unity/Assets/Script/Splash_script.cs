using UnityEngine;
using System.Collections;

public class Splash_script : MonoBehaviour {
	
	void Start () 
	{
		StartCoroutine(loadScene());
	}

	private IEnumerator loadScene()
	{
		yield return new WaitForSeconds(3);
		Application.LoadLevel ("menu");
	}

}
