using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameoverScript : MonoBehaviour {

	int score = 0;
	public GUISkin mySkin;


	void Start () 
	{
		score = PlayerPrefs.GetInt ("Score");
	}

	void OnGUI()
	{
		GUI.skin = mySkin;
		GUI.Label (new Rect (Screen.width / 2-250, 50, 500, 200), "Score: " + score);

	}
}
