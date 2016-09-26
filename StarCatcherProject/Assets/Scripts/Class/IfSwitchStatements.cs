using UnityEngine;
using System.Collections;

public class IfSwitchStatements : MonoBehaviour 
{
	public int jediPassword = 4;

	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			switch (jediPassword) 
			{
			case 4:
			case 3:
				print ("Welcome to the Jedi Temple. Please, enter the keypass.");
				break;

			case 2:
				print ("Incorrect. Please enter the keypass");
				goto case 1;

			case 1:
				print ("You have one more attempt.");
				goto default;

			default:
				print ("You have reached the maximum attempts to enter the keypass. Calling clone troopers for extermination now.");
				break;


				/*At first I had all the cases break, but then I was reading the C# pocket reference and
				 * noticed the 'goto' and got really excited and decided to do that instead. And then I learned you 
				 * could do two cases with the same statement to make "cleaner code" and thought that was cool too.
				 *
				 */
			}
		}
	}
		
}
