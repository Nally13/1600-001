using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	public GameObject[] players;

	void Start ()
	{
		players = GameObject.FindGameObjectsWithTag ("Player");

		for (int i = 0; i < players.Length; i++) 
		{
			Debug.Log ("Player Number " +i+ " is named " + players [i].name);
		}
	}
}

/*int[] myIntArray = new int[5];

	void Start ()
	{
		myIntArray [0] = 13;
		myIntArray [1] = 75;
		myIntArray [2] = 5;
		myIntArray [3] = 913;
		myIntArray [4] = 1000;
		}
	}
}*/