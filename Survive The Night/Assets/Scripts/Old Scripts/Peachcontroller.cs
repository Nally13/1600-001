﻿using UnityEngine;
using System.Collections;

public class Peachcontroller : MonoBehaviour 
{
	public float maxSpeed  = 10f;
	bool facingRight = true;


	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;
	bool canJump;
	int jumpCount;

	// Use this for initialization
	void Start () 
	{
		jumpCount = 0;
		canJump = true;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		float move = Input.GetAxis ("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space) && canJump == true)

		{
			//anim.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, jumpForce));
			jumpCount++;
		}
		if (jumpCount >= 1) 
		{
			canJump = false;
		} 
		else 
		{
			canJump = true;
		}
		if (transform.position.y <= -1.7f) {
			jumpCount = 0;
		}

	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
