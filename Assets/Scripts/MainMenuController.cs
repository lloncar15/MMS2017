using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {
	public Text scoretxt;

	public void Play(){
		SceneManager.LoadScene ("Main");
	}

	void Awake(){
		if(!PlayerPrefs.HasKey("highScore")){
			PlayerPrefs.SetInt ("highScore", 0);
		}
		/*if (!PlayerPrefs.HasKey ("music")) {
			PlayerPrefs.SetInt ("music", 1);
		}
		if (!PlayerPrefs.HasKey ("sound")) {
			PlayerPrefs.SetInt ("sound", 1);
		}*/

		string a = PlayerPrefs.GetInt ("highScore").ToString ();
		scoretxt.text = a;
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
