using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarCollect : MonoBehaviour 
{
	public Text countText;
	private int count = 0;
	public GameObject wolf;

	public AudioClip takeAway;
	public AudioClip collect;
	private AudioSource source { get { return GetComponent<AudioSource> (); } }

	void Start()
	{
		SetCountText ();
		gameObject.AddComponent<AudioSource> ();
		//source.clip = collect;
		source.playOnAwake = false;

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
			//print (count);
			source.PlayOneShot(collect);
		}

		if (other.gameObject.CompareTag("Wolf"))
		{
				count = count - 5;
				if (count < 0)
					count = 0;
				SetCountText();
			source.PlayOneShot (takeAway);
		}
	}

	void SetCountText()
	{
		countText.text = "Score: " + count.ToString ();
	}
}
