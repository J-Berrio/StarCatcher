using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour 
{
	public Text timerText;
	public float myTimer = 100;

	void Start()
	{
		timerText = GetComponent<Text> ();
	}

	void Update()
	{
		myTimer -= Time.deltaTime;
		timerText.text = "Time Left: " + myTimer.ToString ("f0");

	}

}
