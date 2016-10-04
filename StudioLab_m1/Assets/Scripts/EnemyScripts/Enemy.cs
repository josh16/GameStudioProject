using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	//The Target to look at
	public Transform target;

    //reference to dodge player
    public GameObject _PlayerAttacks;

    public Transform player;
	public float playerDistance;
	public float rotationDamping;
	public float moveSpeed;

    //boolean for enemy to dodge
    public bool Nearby = false;
    public int randomNum;
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

        Dodge();
	
	
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

    //Function for enemy to dodge
    void Dodge()
    {
        if(Nearby == true)
        {
            if(randomNum == 1)
            {
                transform.Translate(Vector3.back * DodgeSpeed * Time.deltaTime);

            }
            else
            {
                transform.Translate(Vector3.right * DodgeSpeed * Time.deltaTime);
            }
        }

    }

    public IEnumerator EnemyMovetimer()
    {
        yield return new WaitForSeconds(1f);
        Nearby = false;
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
