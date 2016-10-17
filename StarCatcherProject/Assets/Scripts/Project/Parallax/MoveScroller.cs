using UnityEngine;
using System.Collections;
using System;

public class MoveScroller : MonoBehaviour
{
	public bool canScroll; 
	public static Action<MoveScroller> ScrollThis;

	void Start()
	{
		if (canScroll) 
		{
			ScrollThis (this);
		}
	}

	void OnTriggerEnter()
	{
		canScroll = true;
		Start ();
	}

}
