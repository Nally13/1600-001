using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour 
{
	int numEnemies = 3;
	public GameObject[] players;

	void Start () 
	{
		for (int i = 0; i < numEnemies; i++) 
		{
			Debug.Log ("Creating enemy number: " + i);
		}
		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}
	}
}
