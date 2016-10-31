using UnityEngine;
using System.Collections;

public class StarStuff : MonoBehaviour 
{
	public Transform[] spawnPoints;
	public GameObject[] stars;
	public float spawnFrequency = 1;
	public bool canSpawnStars = true;

	private int i = 0;
	private int j = 0;

	IEnumerator SpawnStars ()
	{
		while (canSpawnStars)
		{
			i = Random.Range(0, spawnPoints.Length - 1);
			stars[j].SetActive(true);
			stars[j].transform.position = spawnPoints[i].position;

			if (j < stars.Length-1)
			{
				j++;
			} 
			else
			{
				j = 0;
			}
			yield return new WaitForSeconds(spawnFrequency);
		}
	}
	void Start () 
	{
		StartCoroutine(SpawnStars());
	}

}