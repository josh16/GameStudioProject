using UnityEngine;
using System.Collections;

public class Crawler : MonoBehaviour 
{
	public Transform player; // Players transform
	public float chaseSpeed;
	static Animator anim; // Declaring the Animator


	void Start () 
	{
		//We want to call the animator at the start
		anim = GetComponent<Animator>();
	}



	// Update is called once per frame
	void Update () 
	{
			
		if (Vector3.Distance (player.position, this.transform.position) < 20) {
			Vector3 direction = player.position - this.transform.position; // Setting the vector 3 direction to the player's position to move towards.

			direction.y = 0; //Setting the y value to 0 so that the enemy does not rotate "Upwards".

			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f); //Rotating towards players transform.
		
		
			anim.SetBool ("isIdle", false); 
			if (direction.magnitude > 10) { // This code will make the enemy chase the player and a specified speed.
				this.transform.Translate (0, 0, chaseSpeed); // Enemy is on the X axis.
				anim.SetBool ("isCrawling", true);
				anim.SetBool ("isAttacking", false);
			} else {	
				anim.SetBool ("isCrawling", false);
				anim.SetBool ("isAttacking", true);
			}
		
		} 

		else 
		{	anim.SetBool ("isIdle", true);
			anim.SetBool("isCrawling", false);
			anim.SetBool ("isAttacking", false);
		}
	

	}




	

}
