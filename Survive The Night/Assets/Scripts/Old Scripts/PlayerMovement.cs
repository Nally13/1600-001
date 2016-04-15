using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float forwardSpeed = 5;
	public float upForce = 5f;

	void FixedUpdate ()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (forwardSpeed, 0);
		if (Input.GetButton ("Jump"))
		{
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, upForce));
		}
	}
}

	/*private Vector3 input;


	// Use this for initialization
	void Start () {
	
	}
	

	void Update () {
		input = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		if (GetComponent<Rigidbody>().velocity.magnitude < maxspeed) 
		{
			GetComponent<Rigidbody> ().AddForce (input * movespeed);
		}
	
	}
}*/