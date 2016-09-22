using UnityEngine;
using System.Collections;

public class ScopeAccess : MonoBehaviour 
{
	public float speed;
	private Vector3 currentPos;
	
	void Update () 
	{
		AccessSpeed ();
		
	}

	void AccessSpeed ()
	{
		currentPos.x = speed * Time.deltaTime;
		transform.Translate (currentPos);
	}
}
