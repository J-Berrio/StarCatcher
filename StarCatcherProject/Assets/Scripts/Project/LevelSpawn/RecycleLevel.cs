using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour 
{
	//public List <SendToRecycler> recycleList;
	//private Vector3 movePos;

	//void SendThisHandler(SendToRecycler _r)
	//{
	//	recycleList.Add (_r);
	//}

	//void Start()
	//{
	//	recycleList = new List<SendToRecycler> ();
	//	SendToRecycler.SendThis += SendThisHandler;
	//}

	//void OnTriggerEnter()
	//{
	//	int i = UnityEngine.Random.Range (0, recycleList.Count - 1);
	//	movePos.x = Statics.nextPosition;
	//	recycleList [i].transform.position = movePos;
	//	recycleList.RemoveAt (i);
	//	Statics.nextPosition += Statics.distance;
	//}


	private Vector3 newLocation;
	public List<SendToRecycler> recyclableList;
	private int i = 0;

	void Start ()
	{
		recyclableList = new List<SendToRecycler>();
		SendToRecycler.RecycleAction += RecycleActionHandler;
	}

	private void RecycleActionHandler(SendToRecycler _r)
	{
		recyclableList.Add(_r);
	}

	void OnTriggerEnter()
	{
		i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
		newLocation.x = Statics.nextPosition;
		recyclableList[i].cube.position = newLocation;
		Statics.nextPosition += Statics.distance;
		if (recyclableList.Count > 0)
			recyclableList.RemoveAt(i);
	}

}
