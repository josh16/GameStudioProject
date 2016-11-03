using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour 
{
	public float gr_speed;
	Rigidbody rb;


	//Grenade Variables
	public GameObject grenade;
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
			
			Instantiate(grenade, transform.position, transform.rotation);
			rb.AddForce(Vector3.forward * gr_speed* Time.deltaTime);

			GrenadeCounter = 0;
			Debug.Log ("Button is being pressed!");

		}
		GrenadeCounter += Time.deltaTime;
	}



}
