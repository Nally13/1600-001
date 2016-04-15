using UnityEngine;
using System.Collections;

public class playermovement2 : MonoBehaviour 
{
	public float Speed = 10f;
	private float movex = 0f;
	private float movey = 0f;

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		if (Input.GetKey (KeyCode.A))
			movex = -1;
		else if (Input.GetKey (KeyCode.D))
			movex = 1;
		else
			movex = 0;
		if (Input.GetKey (KeyCode.W))
			movey = 1;
		else if (Input.GetKey (KeyCode.S))
			movey = -1;
		else movey = 0;
	}

	void FixedUpdate (){
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (movex * Speed, movey * Speed);
	}
}


// Update is called once per frame
/*void Update () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);*/