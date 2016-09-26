using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{
	void Start()
	{
		EquiptmentCheck ();
	}

	void EquiptmentCheck()
	{
		string[] strings = new string[5];

		strings[0] = "Lightsaber";
		strings[1] = "ComLink";
		strings[2] = "Breathing Device";
		strings[3] = "Holocron";
		strings[4] = "Training Remote";

		foreach(string item in strings)
		{
			print(item);
		}

	}
}


