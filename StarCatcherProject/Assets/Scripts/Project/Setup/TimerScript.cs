using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour 
{
	public Text timerText;
	public float myTimer = 100; 
	private bool timerIsActive = true;
	//private GameOverScript over;
	public Canvas gameOverMenu;

	void Start()
	{
		timerText = GetComponent<Text> ();
		//GameOverScript over = GetComponent<GameOverScript>();
	}

	void Update()
	{
		if (timerIsActive)
		{
			myTimer -= Time.deltaTime;
			timerText.text = "Time Left: " + myTimer.ToString ("f0");
			if (myTimer < 0) 
			{
				myTimer = 0;
				timerIsActive = false;
				GameOver ();
			}
		}
	}

	public void GameOver ()
	{
		gameOverMenu.enabled = true;
	}
}
