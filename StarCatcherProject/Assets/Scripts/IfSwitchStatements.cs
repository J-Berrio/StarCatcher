using UnityEngine;
using System.Collections;

public class IfSwitchStatements : MonoBehaviour 
{
	public int jediPassword = 3;

	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			switch (jediPassword) 
			{
			case 3:
				print ("Welcome to the Jedi Temple. Please, enter the keypass.");
				break;

			case 2:
				print ("Incorrect. Please enter the keypass");
				break;

			case 1:
				print ("You have one more attempt.");
				break;

			default:
				print ("You have reached the maximum attempts to enter the keypass. Calling clone troopers for extermination now.");
				break;
			}
		}
	}
		
}
