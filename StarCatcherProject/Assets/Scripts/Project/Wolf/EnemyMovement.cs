using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	public Transform goal;
	public float time = 5;

	void Start()
	{
		StartCoroutine (Spawner ());
	}

	IEnumerator Spawner()
	{
		yield return new WaitForSeconds (time);
		NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		agent.destination = goal.position;
	}

}
