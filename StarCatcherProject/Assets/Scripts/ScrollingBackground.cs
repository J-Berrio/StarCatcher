using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollingBackground : MonoBehaviour 
{
	public List <MoveScroller> scrollList;
	private Vector3 movePos;

	void ScrollThisHandler(MoveScroller _m)
	{
		scrollList.Add (_m);
	}

	void Start()
	{
		scrollList = new List<MoveScroller> ();
		MoveScroller.ScrollThis += ScrollThisHandler;
	}

	void OnTriggerEnter()
	{
		int i = UnityEngine.Random.Range (0, scrollList.Count - 1);
		movePos.x = StaticVars.nextPosition;
		scrollList [i].transform.position = movePos;
		scrollList.RemoveAt (i);
		StaticVars.nextPosition += StaticVars.length;
	}

}