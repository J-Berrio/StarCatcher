using UnityEngine;
using System.Collections;

public class CloneStar : MonoBehaviour 
{
	public Transform[] spawnPoints;
	public Transform star; 
	public float spawnFrequency = 1;
	public bool canSpawnStars = true; 

	private int i = 0;

	IEnumerator SpawnStars ()
	{
		while (canSpawnStars) 
		{
			i = Random.Range (0, spawnPoints.Length);
			Instantiate(star, spawnPoints[i].position, Quaternion.identity);
			yield return new WaitForSeconds (spawnFrequency); 
		}
	}

	void Start ()
	{
		StartCoroutine (SpawnStars());
	}
}
