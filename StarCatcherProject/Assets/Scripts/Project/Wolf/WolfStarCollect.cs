using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WolfStarCollect : MonoBehaviour 
{
	//public GameObject star;
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "player") 
		{
			other.gameObject.SetActive (false);
		}
	}
}