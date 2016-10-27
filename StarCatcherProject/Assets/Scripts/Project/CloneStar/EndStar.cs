using UnityEngine;
using System.Collections;

public class EndStar : MonoBehaviour 
{
	public float forceDuration =  0.1f;
	public float endTime = 3;
	private Rigidbody rigid;
	public float forceRange = 10;
	public float torqueRange = 2;
	private Vector3 forceVector;
	private Vector3 torqueVector;
	public int forceTime = 10;
	public float gravity =50f;
	private Vector3 tempPosition;





	void Start()
	{
		rigid = GetComponent<Rigidbody> ();
		StartCoroutine (RunRandomForce());
	}

	void Update()
	{
		tempPosition.y -= gravity;

	}
	IEnumerator RunRandomForce()
	{
		while (forceTime > 0) 
		{
			yield return new WaitForSeconds (forceDuration);
			torqueVector.z = Random.Range(-torqueRange,torqueRange);
			forceVector.x = Random.Range (-forceRange, forceRange);
			rigid.AddForce (forceVector);
		}
	}
	
	void OnCollisionEnter()
	{
		Destroy (gameObject, endTime);
	}
}
