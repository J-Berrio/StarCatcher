using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleComponent : MonoBehaviour 
{
	private Vector3 newLocation;
	//private int i = 0;
	//public List<Recycler> recycleAbleList;

	//void Start()
	//{
	//	recycleAbleList = new List<Recycler>();
	//	Recycler.RecycleAction += RecycleActionHandler;
	//}

	//private void RecycleActionHandler(Recycler obj)
	//{
	//	recycleAbleList.Add(obj);
	//}

	void OnTriggerEnter ()
	{
		//newLocation.x = StaticVars.nextSectionPos;
		//transform.localPosition = newLocation; ---->recycleAbleList[i].cube.position = newLocation;
		//StaticVars.nextSectionPos += StaticVars.distance;

		//if(if<recycleAbleList.Count-1)
		//{i++
		//}
	}
}
