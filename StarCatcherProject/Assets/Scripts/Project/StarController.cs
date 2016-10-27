using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour 
{
	public GameObject stars;
	public GameObject spawnBox;
	public int starCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;


	void Start()
	{
		StartCoroutine (SpawnWaves());

	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < starCount; i++)
			{
				Vector3 spawnPosition = spawnBox.transform.position;
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(stars, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
