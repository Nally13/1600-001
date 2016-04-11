using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour 
{
	public bool grounded = true;
	public float jumpPower = 190;
	private bool hasJumped = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (!grounded && GetComponent<Rigidbody2D>().velocity.y == 0) {
			grounded = true;
		}
		if(Input.GetButtonDown("Fire1") && grounded == true) 
			{
				hasJumped = true;
	
	}
}

			void FixedUpdate ()
			{
				if(hasJumped) {
					GetComponent<Rigidbody2D>().AddForce(transform.up*jumpPower);
					grounded = false;
					hasJumped = false;
		}
	}
}
