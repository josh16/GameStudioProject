﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	//The Target to look at
	public Transform target;
	public Transform CurrentPos;


    //Weapon instantiation
	//public GameObject EnemyBullet;
	//public float EnemyBullet_Speed;
	//private float counter = 0;
	public float delayTime = 7f;

	public GameObject Position_1;
	public GameObject Position_2;


	//Enemy's Transform, damping, searching for player's distance and move speed variables
	public Transform player;
	public float playerDistance;
	public float rotationDamping;
	public float moveSpeed;
	public float DodgeSpeed;

	// Use this for initialization
	void Start () 
	{
		
	}

	void Update () 
	{
		playerDistance = Vector3.Distance (player.position,	transform.position);

		if (playerDistance < 30f) 
		{
			lookAtPlayer ();
		}


	
		if (playerDistance < 20f) 
		{

			if (playerDistance > 8) 
			{
				//calling the chase function
				chase();
			}

		}
	
	}


	void lookAtPlayer()
	{

		Quaternion rotation = Quaternion.LookRotation (player.position - transform.position);

		//Slerp rotates one object to another in a given amount of time.
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
	}

	//Function for chasing the player
	void chase()
	{
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}

    

	public IEnumerator EnemyMovetimer()
    {
        yield return new WaitForSeconds(1f);
        Nearby = false;
    }
	
	
	public bool Nearby = false;


	void OnTriggerEnter(Collider other)
	{
		//Random generating Variable
		int randomNum = Random.Range(0, 2);



		if (other.gameObject.CompareTag ("PlayerBullet")) 
		{
			
			Nearby = true;

			if(Nearby == true)
			{
				if (randomNum < 1)
				{
					transform.Translate(Vector3.left * DodgeSpeed * Time.deltaTime);

				} 
				else
				{
					transform.Translate (Vector3.right * DodgeSpeed * Time.deltaTime);

				}
			
			}

		}

	}
		



}
