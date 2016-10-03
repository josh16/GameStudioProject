using UnityEngine;
using System.Collections;

public class RayCastShoot : MonoBehaviour {

	public int gunDamage =1;
	public float fireRate = .25f;
	public float weaponRange = 50f;
	public float hitForce = 100f;
	public Transform gunEnd;


	//Variables for the camera
	private Camera fpsCam;
	//This will control how long the lazer will be visible in the game scene.
	private WaitForSeconds shotDuration = new WaitForSeconds(0.7f);

	//AudioSource
	//private AudioSource gunAudio;

	private LineRenderer laserLine;

	//This will give a timer for how long the player can shoot his/her next fire
	private float nextFire;


	void Start()
	{
		laserLine = GetComponent<LineRenderer> ();
		//gunAudio = GetComponent<AudioSource> ();
		fpsCam = GetComponentInParent<Camera> ();

	}



	void Update()
	{
		//Checks player fire button and if enough time has passed in order for the next shot.
		if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
		}
	
		//Calling thie shotEffect coroutine.
		StartCoroutine (ShotEffect());

		//This will aim in the middle of the screen.
		Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
		RaycastHit hit;

		laserLine.SetPosition (0, gunEnd.position);

		if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit, weaponRange)) 
		{
			laserLine.SetPosition (1, hit.point);
		} 

		else 
		{
			laserLine.SetPosition (1, rayOrigin + (fpsCam.transform.forward * weaponRange));
		}

	}

	//
	private IEnumerator ShotEffect()
	{
		//gunAudio.Play ();

		//This will turn on and off the laser line.
		laserLine.enabled = true;
		yield return shotDuration;
		laserLine.enabled = false;
	}






}
