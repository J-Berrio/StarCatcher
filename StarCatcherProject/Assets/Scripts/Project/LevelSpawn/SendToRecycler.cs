using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour
{
	public bool canRecycle; 
	public static Action<SendToRecycler> SendThis;
	
	void Start()
	{
		if (canRecycle) 
		{
			SendThis (this);
		}
	}

	void OnTriggerEnter()
	{
		canRecycle = true;
		Start ();
	}

}
