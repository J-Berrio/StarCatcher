using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LogoLoader : MonoBehaviour 
{
	void Start()
	{
		StartCoroutine ("Countdown");
	}

	private IEnumerator Countdown ()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(1);
	}

}
