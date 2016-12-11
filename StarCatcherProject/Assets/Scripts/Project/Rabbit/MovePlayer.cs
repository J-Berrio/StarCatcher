﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour 
{
	public float speed = 10f;
	private CharacterController controller;
	private Vector3 tempPosition;
	public float gravity = 3f;


	public float jumpSpeed = 30f;
	int AlowedJumps = 1; 
	int JumpCounter = 0;

	public int slideDuration = 100;
	public float slideTime = 0.1f;

	private Animator animator;
	int jumpHash = Animator.StringToHash("Jump");
	int landHash = Animator.StringToHash ("Land");

	public AudioClip sound;
	private AudioSource source { get { return GetComponent<AudioSource> (); } }

	void Start ()
	{
		controller = GetComponent<CharacterController> ();
		animator = GetComponent<Animator> ();

		gameObject.AddComponent<AudioSource> ();
		source.clip = sound;
		source.playOnAwake = false;
	}

	void Update()
	{
		HandleLayers ();

		if (controller.velocity.y < 0)
			{
				animator.SetBool(landHash, true);
			}

		if (Input.GetKeyDown (KeyCode.Space))
			{
				animator.SetTrigger (jumpHash);
				

				if (controller.isGrounded) 
				{
					tempPosition.y = jumpSpeed;
					JumpCounter = 0;
					animator.ResetTrigger (jumpHash);
					animator.SetBool (landHash, false);
					PlayJump ();
				}

				if (!controller.isGrounded && JumpCounter < AlowedJumps) 
				{
					tempPosition.y = jumpSpeed;
					JumpCounter++;
					PlayJump ();
				}
			}
			
		tempPosition.y -= gravity;
		tempPosition.x = speed * Input.GetAxis ("Horizontal");
		controller.Move (tempPosition * Time.deltaTime);
	
		animator.SetFloat ("Speed", Mathf.Abs (Input.GetAxis("Horizontal")));

		if(Input.GetKeyDown(KeyCode.S))
			{
				StartCoroutine (Slide ());	
			}
	}

	private void HandleLayers ()
	{
		if(controller.isGrounded)
		{
			animator.SetLayerWeight(1,0);
			if (Input.GetKeyDown (KeyCode.Space))
			{
				animator.SetLayerWeight (1, 1);
			}
		}
		else 
		{
			animator.SetLayerWeight(1,1);
		}
	}

	IEnumerator Slide()
	{
		int durationTemp = slideDuration;

		float speedTemp = speed;
		speed += speed;
		while (slideDuration > 0) 
		{
			slideDuration--;
			yield return new WaitForSeconds (slideTime);
		}
		speed = speedTemp;
		slideDuration = durationTemp;
	}

	void PlayJump()
	{
		source.PlayOneShot (sound);
	}

}
