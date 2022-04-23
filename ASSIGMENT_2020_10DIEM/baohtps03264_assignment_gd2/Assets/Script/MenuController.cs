using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour {
	[SerializeField]
	private GameObject pausePanel;
	[SerializeField]
	private Button resumeGame;
	public void pauseGame(){
		Time.timeScale = 0;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener (()=>resumesGame());
	}
	public void resumesGame(){
		Time.timeScale = 1;
		pausePanel.SetActive (false);
	}
	public void gotoMenu(){
		Time.timeScale = 1;
        SceneManager.LoadScene("menu");

    }
	public void restartGame(){
		Time.timeScale = 1;
        SceneManager.LoadScene("main");
    }
}
