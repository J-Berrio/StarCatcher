using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour 
{
	public List <SendToRecycler> recycleList;
	private Vector3 movePos;

	void SendThisHandler(SendToRecycler _r)
	{
		recycleList.Add (_r);
		print (recycleList.Count);
	}

	void Start()
	{
		recycleList = new List<SendToRecycler> ();
		SendToRecycler.SendThis += SendThisHandler;
	}

	void OnTriggerEnter()
	{
		int i = UnityEngine.Random.Range (0, recycleList.Count - 1);
		movePos.x = Statics.nextPosition;
		recycleList [i].transform.position = movePos;
		recycleList.RemoveAt (i);
		Statics.nextPosition += Statics.distance;
	}

}
