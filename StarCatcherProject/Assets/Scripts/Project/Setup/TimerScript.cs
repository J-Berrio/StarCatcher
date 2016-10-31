using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour 
{
	public Text timerText;
	public float myTimer = 100; 
	private bool gameOver = false;
	public Text gameOverText;
	private bool timerIsActive = true;

	void Start()
	{
		timerText = GetComponent<Text> ();

		gameOverText.text = "";
	}

	void Update()
	{
		if (timerIsActive)
		{
			myTimer -= Time.deltaTime;
			timerText.text = "Time Left: " + myTimer.ToString ("f0");
			if (myTimer < 0) {
				myTimer = 0;
				timerIsActive = false;
				GameOver ();
			}

		}
	}

	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;

		SceneManager.LoadScene (0);
		
	}

}
