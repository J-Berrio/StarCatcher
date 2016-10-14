using UnityEngine;
using System.Collections;

public class BushGenerator : MonoBehaviour 
{
	public Transform[] spawnLocations;
	public GameObject[] Bushes;

	void OnTriggerEnter()
		{
		print ("spawn");
		int spawnIndex = Random.Range(0, spawnLocations.Length);
		int bushIndex = Random.Range(0, Bushes.Length);
		Instantiate(Bushes[bushIndex], spawnLocations[spawnIndex].position, spawnLocations[spawnIndex].rotation);
		}
}
	