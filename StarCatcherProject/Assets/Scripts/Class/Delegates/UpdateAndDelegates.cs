using UnityEngine;
using System.Collections;
using System;

public class UpdateAndDelegates : MonoBehaviour 
{
	public int health = 250;
	//Actions are a type of delegate. Delegates contain functions just as vars contain data.
	Action DisplayHealth;
	Action KillPlayer;
	Action EndGame;

	void Start () 
	{
		//We assign the function DisplayHealthHandler to the action DisplayHealth
		DisplayHealth = DisplayHealthHandler;
	}

	void DisplayHealthHandler ()

	{
		print("Health is good.");
		//we unassign all functions from DisplayHealth
		DisplayHealth = null; 
		KillPlayer = KillPlayerHandler;
	}

	void KillPlayerHandler()
	{
		health--;
		print (health);
		if (health < 0) 
		{
			KillPlayer = null;
			EndGame = EndGameHandler;
		}
	}

	void EndGameHandler()
	{
		print ("You died. You didn't even try.");
		EndGame = null;
	}
		
	void Update () 
	{
		//We check if any function is assigned to DisplayHealth
		//if nothing is assigned, DisplayHealth will not run.
		if (DisplayHealth != null) 
		{
			DisplayHealth ();
		}

		if (KillPlayer != null) 
		{
			KillPlayer ();
		}
		if (EndGame != null) 
		{
			EndGame ();
		}
	}
}