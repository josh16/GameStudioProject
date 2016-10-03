using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	//The Target to look at
	public Transform target;

	// Use this for initialization
	void Start () 
{
		
	}

	void Update () {
		

	}


	//Player looks at target when player steps in radius of collider
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			transform.LookAt(target);

		}
	}

	//The Enemy will constantly look at the Player while player is inside the collider
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			transform.LookAt(target);

		}
	}


	//
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			// Code here for when the Enemy Attacks player

		}
	}
		


}
