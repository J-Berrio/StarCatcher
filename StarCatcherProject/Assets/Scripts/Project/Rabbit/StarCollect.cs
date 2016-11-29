using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarCollect : MonoBehaviour 
{
	public Text countText;
	private int count = 0;
	public GameObject wolf;

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
			//print (count);
		}

		if (other.gameObject.CompareTag("Wolf"))
		{
				count = count - 5;
				if (count < 0)
					count = 0;
				SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Score: " + count.ToString ();
	}
}
