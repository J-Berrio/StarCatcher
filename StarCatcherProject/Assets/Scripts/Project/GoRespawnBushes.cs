using UnityEngine;
using System.Collections;
using System;

public class GoRespawnBushes : MonoBehaviour 
{
	public bool canRespawn;
	public static Action<GoRespawnBushes> RespawnThis;

	void Start () 
		{
			if (canRespawn) 
				{
					RespawnThis (this);
				}
		}

	void OnTriggerEnter()
	{
		canRespawn = true;
		Start ();
	}
}

