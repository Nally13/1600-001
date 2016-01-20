using UnityEngine;
using System.Collections;

public class variablesandfunctions : MonoBehaviour 
{
	public int myInt=2;


	void Start () 
	{
	}

	void Update()
	{
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}


	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
