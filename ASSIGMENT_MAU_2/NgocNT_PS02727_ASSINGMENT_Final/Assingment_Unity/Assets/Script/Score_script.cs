using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_script : MonoBehaviour {

	public static int score = 0;

	void OnGUI()
	{
		GUI.Box (new Rect(20, 20, 80, 24), "Score: " + score + "/50");
		GUI.Box (new Rect(110, 20, 80, 24), "Blood: " + Main_script.blood);
		GUI.Box (new Rect(200, 20, 80, 24), "Boss: " + UFO_Boss_script.bloodBoss + "/50");
	}
}
