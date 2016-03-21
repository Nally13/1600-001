using UnityEngine;
using System.Collections;

public class Switchstatements : MonoBehaviour 
{
	public int hours = 5;
		

	void Time () 
	{
		switch (hours)
		{
		case 5:
			print ("Early");
			break;
		case 4:
			print ("Less early");
			break;
		case 3:
			print ("On time");
			break;
		case 2:
			print ("Late");
			break;
		case 1:
			print ("Really late");
			break;
		default:
			print ("Too late");
			break;
		}
	}
}
