using UnityEngine;
using System.Collections;
using System;

public class StarSpawner : MonoBehaviour 
{
	public static Action <Transform> SendSpawner;

	void Start()
	{
		if (SendSpawner != null) 
		{
			SendSpawner (transform);

		}
	}

}
