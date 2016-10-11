using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour 
{
	public CharacterController myCC;
	public float gravity = 1;
	public Vector3 tempPos;


	void Update()
	{
		tempPos.y -= gravity * Time.deltaTime;
		myCC.Move (tempPos);
	}

}
