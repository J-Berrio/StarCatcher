using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarManager : MonoBehaviour
{
	public List<StarSpawner> spawner;
	public List<Star> stars;
	private bool canSpawn = true;
	private int starNum;
	private int spawnerNum;

	void SpawnerHandler(Transform _t)
	{
		spawner.Add(_t);
	}

	void StarHandler(Transform _t)
	{
		stars.Add(_t);
	}

	void Start()
	{
		StarSpawner.SendSpawner += SpawnerHandler;
		Star.SendStar += StarHandler;
		if (stars != null && spawner != null) 
		{
			StartCoroutine (Spawn());

		}
	}

	IEnumerator Spawn()
	{
		while (canSpawn) 
		{
			yield return new WaitForSeconds (1);
			stars [starNum].transform.position = spawner [spawnerNum].transform.position;
			stars [starNum].GetComponent<MeshRenderer> ().enabled = true;
			if (starNum < stars.Count-1) 
			{
				starNum++;
			} else 
			{
				starNum = 0;
			}
			if (spawnerNum < spawner.Count-1) 
			{
				spawnerNum++;
			} else 
			{
				spawnerNum = 0;
			}
		}
	}
}
