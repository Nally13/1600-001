using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOverInput : MonoBehaviour 
{
	public Button retryText;
	public Button giveUpText;

	void Start () 
	{
		retryText = retryText.GetComponent<Button> ();
		giveUpText = giveUpText.GetComponent<Button> ();
	}

	public void RetryLevel()
	{
		SceneManager.LoadScene (0);
	}

	public void Return ()
	{
		SceneManager.LoadScene (2);
	}
}
