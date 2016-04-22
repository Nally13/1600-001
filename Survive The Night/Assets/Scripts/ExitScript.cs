using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour 
{
	public void LoadScene (string name)
	{
		SceneManager.LoadScene (name);
	}
}
