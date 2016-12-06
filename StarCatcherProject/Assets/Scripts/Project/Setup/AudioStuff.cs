using UnityEngine;
using System.Collections;

public class AudioStuff : MonoBehaviour {

	public bool playOnAwake;

	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}
}
