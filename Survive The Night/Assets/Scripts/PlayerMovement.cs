using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float movespeed;
	private float maxspeed = 10f;

	private Vector3 input;


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
}
