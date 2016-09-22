using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleComponent : MonoBehaviour 
{
	//public float speed = 2f;
	private Vector3 tempPos;
	private Vector3 newLocation;

/*	private int i;
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

*/
	void OnTriggerEnter ()
	{
		//i = Random.Range (0, recycleAbleList.Count);
		newLocation.x = StaticVars.nextSectionPos;
		transform.localPosition = newLocation; 
		//recycleAbleList[i].cube.position = newLocation;
		StaticVars.nextSectionPos += StaticVars.distance;

		/*if(i == recycleAbleList.Count -1)
		{
			i++;
		}
		*/
	}

}