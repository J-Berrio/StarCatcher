﻿using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour 
{
	public int forceTime = 10;
	public float forceDuration = 0.1f;
	public float forceRange = 10;
	public float torqueRange = 2;

	private Vector3 forceVector;
	private Vector3 torqueVector;
	private Animator anims;
	private Rigidbody rigid;

	void Start()
	{
		anims = GetComponent<Animator>();
		rigid = GetComponent<Rigidbody>();
		StartCoroutine(RunRandomForce());
	}

	IEnumerator RunRandomForce()
	{
		while (forceTime > 0)
		{
			yield return new WaitForSeconds(forceDuration);
			forceVector.x = Random.Range(-forceRange, forceRange);
			torqueVector.z = Random.Range(-torqueRange, torqueRange);
			rigid.AddTorque(torqueVector);
			rigid.AddForce(forceVector);
			forceTime--;
		}
	}

	public void Deactivate()
	{
		gameObject.SetActive(false);
		anims.SetBool("Destroy", false);
	}

	void OnCollisionEnter () 
	{
		//anims.SetBool("Destroy", true);
	}
}