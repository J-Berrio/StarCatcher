using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour {

	public virtual void Start()
	//so that it can be overriden from the Dog script, which is a child of Animals
	{
		Walk ();
	}

	void Walk()
	{
		print ("Walking");
	}
}
