using UnityEngine;
using System.Collections;


public class CrawlerHealth : MonoBehaviour 
{
	//Crawlers health vars
	public float StartingHealth = 100.0f;
	public float CurrentHealth;

	//Crawlers bools
	bool IsDead;
	bool Damaged;

	//Audio files
	public AudioClip damageSound;


	//Particle effect for getting hit? blood? some type of sound?

	// Use this for initialization
	void Start () 
	{
		CurrentHealth = StartingHealth;
	}


	//TakeDamage function
	public void TakeDamage(int amount)
	{
		if (Damaged) 
		{
			CurrentHealth -= StartingHealth; // health is being reduced.
			//damageSound.Play();
		}
	
	
		if (CurrentHealth <= 0) 
		{
			Destroy (this.gameObject);
		}
	
	}


	//Death Animation function and etc.
	/*void Death()
	{
		IsDead = true;


	}
	*/

	// Update is called once per frame
	void Update () 
	{
	
	}
}
