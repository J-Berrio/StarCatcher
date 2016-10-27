using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour
{
	//public bool canRecycle; 
	//public static Action<SendToRecycler> SendThis;
	//
	//void Start()
	//{
	//	if (canRecycle) 
	//	{
	//		SendThis (this);
	//	}
	//}

	//void OnTriggerEnter()
	//{
		//canRecycle = true;
		//Start ();
	//}

	public static Action<SendToRecycler> RecycleAction;
	public bool canBeRecycled = false;
	public Transform cube;

	void Start () {
		cube = this.GetComponent<Transform>();
		if (RecycleAction != null && canBeRecycled)
			RecycleAction(this);
	}

	void OnTriggerEnter ()
	{
		canBeRecycled = true;
		Start();
	}
}
