using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour 
{
	public Text timerText;
	public float myTimer = 100; 
	private bool timerIsActive = true;
	public Canvas gameOverMenu;

	public AudioClip menuSound;
	private AudioSource source { get { return GetComponent<AudioSource> (); } }

	void Start()
	{
		timerText = GetComponent<Text> ();
		gameOverMenu.enabled = false;
		GetComponent<CameraControl> ();
		GetComponent<StarStuff> ();
		GetComponent<Boundary> ();

		gameObject.AddComponent<AudioSource> ();
		source.clip = menuSound;
		source.playOnAwake = false;
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

	public CameraControl cameraControl;
	public StarStuff starStuff;
	public StarStuff secondSpawner;
	public Boundary boundary;

	public void GameOver ()
	{
		gameOverMenu.enabled = true;
		cameraControl.enabled = false; 
		starStuff.StopSpawn ();
		secondSpawner.StopSpawn ();
		boundary.enabled = false;
		source.PlayOneShot (menuSound);
	}
}
