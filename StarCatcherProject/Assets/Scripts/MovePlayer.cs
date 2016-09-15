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

	public int slideDuration = 100;
	public float slideTime = 0.1f;

	IEnumerator Slide()
	{
		//set a temp var to the value of slideDuration
		int durationTemp = slideDuration;

		float speedTemp = speed;
		speed += speed;
		//while loop runs "while" the slideDuration is greater than 0
		while (slideDuration > 0) 
		{
			//Decrement the slideDuration
			slideDuration--;
			//yield "holds" the coroutine
			//return "sends" to the coroutine to do an operation while yielding
			//new creates an instanceof an object
			//waitforseconds is an object that waits for duration time
			yield return new WaitForSeconds (slideTime);


		}

		speed = speedTemp;
		slideDuration = durationTemp;
	}

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

		if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine (Slide ());	
		}
		if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine (Slide ());	
		}
	}
}