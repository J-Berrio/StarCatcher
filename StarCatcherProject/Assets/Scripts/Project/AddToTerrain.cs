using UnityEngine;
using System.Collections;
using System; 

public class AddToTerrain : MonoBehaviour 
{
	public static Action<Transform> SendThis;

	void Awake () 
	{

		SendThis (transform);
	
	}

	void OnBecameInvisible()
	{
		SendThis (transform);
	}
}
