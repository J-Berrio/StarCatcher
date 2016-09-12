using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
	public float speed = 40f;
	private Rigidbody rb;

	void Update () 
	{
		rb = GetComponent<Rigidbody>();
		Vector3 movement = new Vector3 (1f, 0.0f, 0f);
		rb.AddForce (movement * speed);
	}
}
