using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WolfStarCollect : MonoBehaviour 
{
	private int count;
	public Text countText;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
		}
	}
}