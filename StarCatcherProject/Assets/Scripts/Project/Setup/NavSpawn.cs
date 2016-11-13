using UnityEngine;
using System.Collections;

public class NavSpawn : MonoBehaviour
{
	public GameObject nagent;
	public GameObject goalObject;
	private int i = 0;


	void Start()
	{
		Invoke ("SpawnAgent", 2);
	}

	void SpawnAgent()
	{
		GameObject na = (GameObject)Instantiate (nagent, this.transform.position, Quaternion. identity);
		na.GetComponent<NavStuff>().player.transform.position = goalObject.transform.position;
		Invoke ("SpawnAgent", Random.Range (2, 5));
	}
}
