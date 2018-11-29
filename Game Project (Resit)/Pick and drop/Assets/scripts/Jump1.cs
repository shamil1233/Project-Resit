using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump1: MonoBehaviour {

public float jumpForce = 600f;
public LayerMask theGround;
public Transform groundCheck;
bool onTheGround = false;
public float velY;

Rigidbody2D rigBody;

void Start()
{
	rigBody = GetComponent<Rigidbody2D>();
}
void Update()
{
	onTheGround = Physics2D.Linecast(transform.position, groundCheck.position, theGround);
	if(onTheGround && Input.GetButtonDown ("Jump"))
	{
		velY = 0f;	
		rigBody.AddForce(new Vector2(0, jumpForce));
	}
}
}
