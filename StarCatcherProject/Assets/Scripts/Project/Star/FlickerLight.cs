using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour 
{
	Light starLight;
	public float minWaitTime;
	public float maxWaitTime;

	void Start()
	{
		starLight = GetComponent<Light> ();
		StartCoroutine (Flashing ());
	}

	IEnumerator Flashing ()
	{
		while (true) 
		{
			yield return new WaitForSeconds (Random.Range(minWaitTime,maxWaitTime));
			starLight.enabled = !starLight.enabled;
		}
	}
}
