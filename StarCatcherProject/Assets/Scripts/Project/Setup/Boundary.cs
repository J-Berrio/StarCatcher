using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour
{
	void Start()
	{
		Statics.nextPosition = Statics.startPosition; 
	}

	void OnTriggerEnter ()
	{
		RestartLevel ();
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene (1);
	}
}
