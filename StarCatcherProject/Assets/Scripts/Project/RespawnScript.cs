using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RespawnScript : MonoBehaviour 
{
	public List<Transform> LevelArt;


	void AddToList (Transform _t)
	{
		LevelArt.Add (_t);
	}

	void Awake()
	{
		AddToTerrain.SendThis += AddToList;
	}

	void Start()
	{
		

		int i = Random.Range (0, LevelArt.Count - 1);

		LevelArt [i].position = transform.position; 

		LevelArt.RemoveAt (i);
	
	}
}
