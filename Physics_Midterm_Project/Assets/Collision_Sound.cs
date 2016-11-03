using UnityEngine;
using System.Collections;

public class Collision_Sound : MonoBehaviour 
{

	private AudioSource LoudScream;
	public AudioClip soundClip;


	void Awake()
	{
		LoudScream = GetComponent<AudioSource>();
	}


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			LoudScream.PlayOneShot(soundClip, 1f);
			Debug.Log ("Scream sound");

		}

	}

}
