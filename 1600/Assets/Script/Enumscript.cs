using UnityEngine;
using System.Collections;

public class Enumscript : MonoBehaviour {

	public enum direction
	{
		North,
		South,
		East,
		West
	}

	void ChangeDirection (directions_d) {
		currentDirection = _d;
		print (currentDirection);
	}

	public directions currentDirection;

	void OnMouseDown (){

		switch(currentDirection){
		case directions.North:
			ChangeDirection (directions.South);
			break;
		
		case directions.South:
			ChangeDirection (directions.East);
			break;

		case directions.East:
			ChangeDirection (directions.West);
			break;

		case directions.West:
			ChangeDirection (directions.North);
			break;
		}
	}
}
