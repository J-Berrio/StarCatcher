using UnityEngine;
using System.Collections;

public class ScrollTrigger : MonoBehaviour 
{
	private Vector3 movePos;
	public float speed = 45;

	void Update () 
	{
		movePos.x = speed * Time.deltaTime;
		transform.Translate(movePos);
	}
}
