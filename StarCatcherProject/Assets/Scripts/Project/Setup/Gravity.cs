using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	CharacterController myCC;
	Vector3 tempPos;
	public float gravity = 1;
	public float sideForce = 1;

	void Start () {
		myCC = GetComponent<CharacterController>();
	}

	void Update () {
		tempPos.y -= gravity*Time.deltaTime;
		tempPos.z = sideForce;

		if(myCC.isGrounded)
		{
			tempPos.y = 0;
		}
		myCC.Move(tempPos);
	}
}
