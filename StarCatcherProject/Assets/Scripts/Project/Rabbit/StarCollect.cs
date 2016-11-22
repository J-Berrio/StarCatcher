using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarCollect : MonoBehaviour 
{
	public Text countText;
	private int count = 0;

	void Start()
	{
		SetCountText ();
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
			print (count);
		}
	}


	void SetCountText()
	{
		countText.text = "Score: " + count.ToString ();
	}
}
