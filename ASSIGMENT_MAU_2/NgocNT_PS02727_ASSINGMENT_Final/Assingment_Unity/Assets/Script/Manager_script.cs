using UnityEngine;
using System.Collections;

public class Manager_script : MonoBehaviour {

	public void ChangeToSceneTo (string sceneName) 
	{
		Application.LoadLevel (sceneName);
	}

	public void ExitFunc () 
	{
		Application.Quit ();
	}
}
