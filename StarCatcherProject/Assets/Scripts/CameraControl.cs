using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
	public float speed = 40f;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		MoveCamera ();	
	}

	void MoveCamera()
	{
		Vector3 movement = new Vector3 (1f, 0.0f, 0f);
		rb.AddForce (movement * speed * Time.deltaTime);
	}
}

