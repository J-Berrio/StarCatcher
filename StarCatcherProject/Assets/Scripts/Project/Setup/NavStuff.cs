using UnityEngine;
using System.Collections;

public class NavStuff : MonoBehaviour 
{
	public NavMeshAgent myAgent;
	public Transform player;

	void Start()
	{
		myAgent.GetComponent<NavMeshAgent> ();
	}

	void Update()
	{
		myAgent.destination = player.position;
	}
}
