using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameoverScript : MonoBehaviour {

	int score = 0;

	void Start () 
	{
		score = PlayerPrefs.GetInt ("Score");
	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 100, 50), "GAME OVER");

		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
		if (GUI.Button (new Rect (Screen.width / 2 - 100, 350, 200, 40), "I WON'T GIVE UP!")) 
		{
			SceneManager.LoadScene (0);
		}
	}
}
