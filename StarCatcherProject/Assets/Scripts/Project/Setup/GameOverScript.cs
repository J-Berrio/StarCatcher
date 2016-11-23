using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour 
{
	public Canvas gameOverMenu;
	public Button quitButton;
	public Button playAgainButton;

	void Start()
	{
		gameOverMenu = gameOverMenu.GetComponent<Canvas> ();
		quitButton = quitButton.GetComponent<Button> ();
		playAgainButton = playAgainButton.GetComponent<Button> ();
		gameOverMenu.enabled = false;

	}

	public void GameOver ()
	{
		gameOverMenu.enabled = true;
	}

	public void QuitPress ()
	{
		SceneManager.LoadScene (1);
	}

	public void PlayAgain()
	{
		SceneManager.LoadScene (2);
	}

}
