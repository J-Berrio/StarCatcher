using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WolfAttack : MonoBehaviour 
{
	public Text scoreText;
	public int minusPoints;

	void Start()
	{
		Statics.points = 0;
		SetCountText();
	}

	void OnTriggerEnter()
	{
		Statics.count = Statics.count - minusPoints;
		SetCountText();
	}

	void SetCountText()
	{
		if (Statics.count < 0)
			Statics.count = 0;

		scoreText.text = "Score: " + Statics.count.ToString();
	}

	void Update()
	{
		Statics.points = Statics.count;
	}
}
