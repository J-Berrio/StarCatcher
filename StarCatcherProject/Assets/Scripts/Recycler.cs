using UnityEngine;
using System.Collections;
using System;

public class Recycler : MonoBehaviour 
{
	public static Action<Recycler> RecycleAction;
	public bool canBeRecycled; 
	public Transform cube;

	void Start()
	{
		cube = this.GetComponent<Transform> ();
		if (RecycleAction != null && canBeRecycled) 
		{
			RecycleAction (this);
		}
	}

	void OnTriggerEnter()
	{ 
		canBeRecycled = true;
		Start ();
	}

}
