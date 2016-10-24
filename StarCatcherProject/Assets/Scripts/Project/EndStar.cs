using UnityEngine;
using System.Collections;

public class EndStar : MonoBehaviour 
{
	public float endTime = 3;

	IEnumerator EndStars()
	{
		yield return new WaitForSeconds (endTime);
	}
	
	void OnCollisionEnter()
	{
		Destroy (gameObject, endTime);
	}
}
