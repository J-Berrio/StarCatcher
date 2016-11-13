using UnityEngine;
using System.Collections;

public class NavStuff : MonoBehaviour 
{
	public NavMeshAgent myAgent;
	public Transform player;
	//private int i = 0;

	void Start()
	{
		myAgent.GetComponent<NavMeshAgent> ();
	}

	void Update()
	{
		myAgent.destination = player.transform.position;
	}
}
