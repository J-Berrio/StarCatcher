using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleComponent : MonoBehaviour 
{
	private Vector3 tempPos;
	private Vector3 newLocation;

	private int i;
	public List<Recycler> recycleAbleList;

	void Start()
	{
		recycleAbleList = new List<Recycler>();
		Recycler.RecycleAction += RecycleActionHandler;
	}

	void RecycleActionHandler(Recycler obj)
	{
		recycleAbleList.Add(obj);
	}
		
	void OnTriggerEnter ()
	{
		
		i = Random.Range(0,recycleAbleList.Count -1);
		newLocation.x = StaticVars.nextSectionPos;
		recycleAbleList[i].cube.position = newLocation;
		StaticVars.nextSectionPos += StaticVars.distance;

		if(recycleAbleList.Count > 0)
		{
			recycleAbleList.RemoveAt(i);
		}

	}

}