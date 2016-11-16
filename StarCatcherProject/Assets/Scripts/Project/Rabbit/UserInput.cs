using UnityEngine;
using System.Collections;
using System;

public class UserInput : MonoBehaviour 
{
	public static Action<KeyCode> UserInputs;

	void Update()
	{
		if(Input.GetKeyDown (KeyCode.D) && UserInputs != null)
		{
			UserInputs (KeyCode.D);
		}

		if (Input.GetKeyDown (KeyCode.A) && UserInputs != null) 
		{
			UserInputs (KeyCode.A);
		}
	}
}
