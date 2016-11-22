using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WolfAttack : MonoBehaviour 
{
	public Text scoreText;

	void Start()
	{
		//Statics.count = 0;
		//SetScoreText();
	}

	void OnTriggerEnter()
	{
		Statics.count = Statics.count - 5;
		if (Statics.count < 0)
			Statics.count = 0;
		SetScoreText();
	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + Statics.count.ToString();
	}
		
	void Update()
	{
		//Statics.count += Statics.count;
	}
}
