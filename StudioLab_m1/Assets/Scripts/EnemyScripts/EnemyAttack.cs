using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour 
{
	//EnemyAttack Variables.
	public int AttackDamage = 3;
	public float TimeBetweenAttacks = 3.0f;


	//Refs to player and health
	GameObject player;
	PlayerHealth playerHealth;
	bool playerInRange;
	float timer;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player"); 
		playerHealth = player.GetComponent<PlayerHealth>(); //Pulling the player health from the PlayerHealth script.
	}
	


	//Trigger function for entering
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == player) // refs to player game object, declared on top.
		{
			playerInRange = true;
		}
	}	

	//Trigger function for exiting
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject == player) 
		{
			playerInRange = false;
		}
	}

	//Attack function
	void Attack()
	{
		timer = 0.0f; // Timer is set to 0 at the start.

		if (playerHealth.CurrentHealth > 0) 
		{
			playerHealth.TakeDamage(AttackDamage); // Amount of damage is 10, it's declared at the top.
		}
	}


	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		if (timer >= TimeBetweenAttacks && playerInRange) // time in bewtween enemy attacks
		{
			Attack (); // Calling the attack method
		}
	
	
		/*if (playerHealth.CurrentHealth <= 0) 
		{

		}
		*/
	}	
}
