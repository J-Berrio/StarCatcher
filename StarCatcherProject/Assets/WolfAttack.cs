using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WolfAttack : MonoBehaviour 
{
	private int count;
	public Text countText;
	public GameObject wolf;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Enemy") && count > 0) 
		{
				count = count - 1;
				SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
	}
}
