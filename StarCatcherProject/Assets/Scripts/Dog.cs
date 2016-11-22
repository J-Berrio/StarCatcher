using UnityEngine;
using System.Collections;

public class Dog : Animals {

	void Start()
	{
		Bark ();


	}
	//also need to add in this start reference to what were overriding

	void Bark()
	{
		print ("Barking");
	}

}
