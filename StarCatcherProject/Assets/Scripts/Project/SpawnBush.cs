using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnBush : MonoBehaviour 
{
	public List <GoRespawnBushes> spawnBushes;
	public Transform [] spawnLocation;
	private Vector3 respawnPos;

	void Start()
		{
			spawnBushes = new List<GoRespawnBushes> ();
			GoRespawnBushes.RespawnThis += RespawnThisHandler;
			
		}

	void RespawnThisHandler(GoRespawnBushes _s)
		{
			spawnBushes.Add (_s);
		}

	void OnTriggerEnter()
		{
			int i = UnityEngine.Random.Range (0, spawnBushes.Count);
			spawnBushes [i].transform.position = respawnPos; 
			spawnBushes.RemoveAt (i);
		}
}
