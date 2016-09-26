using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	public GameObject[] herbs;

	void Start()
	{
		herbs = GameObject.FindGameObjectsWithTag ("Herbs");
		for (int i = 0; i < herbs.Length; i++) 
		{
			print("Herb number" + i + " is called " +herbs[i].name);
		}
	}
}
