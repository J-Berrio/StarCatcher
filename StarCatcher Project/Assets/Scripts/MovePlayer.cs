using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour 
{
	//set speed 
	public float speed = 10f;
	//CC component
	private CharacterController controller;
	//temp Vect3 to move character
	private Vector3 tempPosition;
	public float gravity = 3f;
	public float jumpSpeed = 30f;
	int AlowedJumps = 1; 
	int JumpCounter = 0;

	void Start () 
	{
		//to 'find' the cc
		controller = GetComponent<CharacterController> ();
	}

	void Update()
	{
		//input to be able to jump
		if (Input.GetKeyDown (KeyCode.Space))
		{
			if (controller.isGrounded) 
			{
				tempPosition.y = jumpSpeed;
				JumpCounter = 0;
			}

			if (!controller.isGrounded && JumpCounter < AlowedJumps) 
			{
				tempPosition.y = jumpSpeed;
				JumpCounter++;
			}
		}

		//add gravity
		tempPosition.y -= gravity;

		//the actual input from keyboard to character
		tempPosition.x = speed * Input.GetAxis ("Horizontal");
		//to access controller & make it move character in seconds/not frames
		controller.Move (tempPosition * Time.deltaTime);

	}
}