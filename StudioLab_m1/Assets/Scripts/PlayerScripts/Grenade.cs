using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour 
{
	
	public Rigidbody grenade;


	//Grenade Variables
	//public GameObject grenade;
	public float grenadeSpeed;
	private float GrenadeCounter = 1.0f;
	public float delayGrenadeTime = 8.0f;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GrenadeThrow();

	}

	void GrenadeThrow()
	{
		if (Input.GetKeyDown(KeyCode.E) && GrenadeCounter > delayGrenadeTime) 
		{
			
			Rigidbody instantiatedgrenade = Instantiate (grenade, transform.position, transform.rotation) as Rigidbody;
			instantiatedgrenade.velocity = transform.TransformDirection (new Vector3 (0, 0, -grenadeSpeed));

			//rb.AddForce(Vector3.forward * gr_speed* Time.deltaTime);

			GrenadeCounter = 0;
			Debug.Log ("Button is being pressed!");

		}
		GrenadeCounter += Time.deltaTime;
	}



}
