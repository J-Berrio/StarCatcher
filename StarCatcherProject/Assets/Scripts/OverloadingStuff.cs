using UnityEngine;
using System.Collections;

public class OverloadingStuff : MonoBehaviour 
{
	void Update()
	{
		//at this point, in the parameters you write which one you want to use (int or string)
		Move (50);
	}
	//original function
	void Move(int speed)
	{
		Vector3 vector = new Vector3(speed, 0, 0);
		transform.position = vector * Time.deltaTime;
	}

	//if we wanted it to move a different way and use Move()
	void Move(string speed)
	{
		Vector3 vector;
		switch (speed) {
		case "Fast":
			vector = new Vector3 (100, 0, 0);
			break;

		case "Slow":
			vector = new Vector3 (1, 0, 0);
			break;

			transform.position = vector * Time.deltaTime;
		}

	}
}
