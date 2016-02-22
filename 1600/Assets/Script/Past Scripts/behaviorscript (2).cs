using UnityEngine;
using System.Collections;

public class behaviorscript : MonoBehaviour 
{
	void Start ()
	{
	}

	void Update () 
	{
		if(Input.GetKeyDown (KeyCode.R)) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		if(Input.GetKeyDown (KeyCode.G)) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		if(Input.GetKeyDown (KeyCode.B)) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
