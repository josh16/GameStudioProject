using UnityEngine;
using System.Collections;

public class Crawler : MonoBehaviour 
{
	public Transform player; // Players transform
	public float chaseSpeed;
	static Animator anim; // Declaring the Animator

	public float DodgeSpeed = 2;

	Rigidbody rb;

	void Start () 
	{
		//We want to call the animator at the start
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody> ();
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

	public bool Nearby = false;

	void OnTriggerEnter(Collider other)
	{

		//Dodge

		if (other.gameObject.CompareTag ("PlayerBullet")) 
		{
			
			Nearby = true;

			if (Nearby == true) 
			{
				anim.SetTrigger("Pounce");
				StartCoroutine (TimeDodge());
			}
				

		}

	}

	private IEnumerator TimeDodge ()
	{
		yield return new WaitForSeconds (0.5f);
		Dodge ();
	}

	public void Dodge()
	{
		int randomNum = Random.Range(0,3);

		if (randomNum < 1)
		{
			transform.Translate(Vector3.left * DodgeSpeed* Time.deltaTime);
			//rb.AddForce(Vector3.left * DodgeSpeed* Time.deltaTime);
			//Vector3.MoveTowards(transform.position,transform.position + Vector3.left *DodgeSpeed,30);

		} 
		else
		{
			transform.Translate (Vector3.right * DodgeSpeed* Time.deltaTime);
			//rb.AddForce(Vector3.right * DodgeSpeed* Time.deltaTime);
			//Vector3.MoveTowards(transform.position,transform.position + Vector3.right *DodgeSpeed,30);

		}
	}

	

}
