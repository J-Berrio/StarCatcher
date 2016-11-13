using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WolfStarCollect : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
		}
	}
}