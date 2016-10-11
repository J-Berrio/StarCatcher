using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour 
{
	public NavMeshAgent myAgent;
	public Transform player; 

	void Update()
	{
		myAgent.destination = player.position;
	}



}
