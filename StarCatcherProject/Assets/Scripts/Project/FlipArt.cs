using UnityEngine;
using System.Collections;

public class FlipArt : MonoBehaviour
{
	public Transform characterArt;
	public bool forward = true;

	void FlipCharacter(KeyCode _keyCode)
	{
		switch (_keyCode) 
		{
			case KeyCode.D:
				if (forward) 
				{
					characterArt.Rotate (0, 180, 0);
					forward = false;
				}
		
				break;

			case KeyCode.A:
				if (!forward) 
				{
					characterArt.Rotate (0, 180, 0);
					forward = true;
				}

				break;
		}
	}

	void Start()
	{
		UserInput.UserInputs += FlipCharacter;
	}

}
