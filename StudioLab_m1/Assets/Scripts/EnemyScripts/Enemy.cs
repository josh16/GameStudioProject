using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	//The Target to look at
	public Transform target;

	public Transform player;
	public float playerDistance;
	public float rotationDamping;



	// Use this for initialization
	void Start () 
{
		
	}

	void Update () 
	{
		playerDistance = Vector3.Distance (player.position,	transform.position);

		if (playerDistance < 25f) 
		{
			lookAtPlayer ();
		}

	}


	void lookAtPlayer()
	{

		Quaternion rotation = Quaternion.LookRotation (player.position - transform.position);
		//Slerp rotates one object to another in a given amount of time.
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
	}



	/*
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
		
	*/

}
