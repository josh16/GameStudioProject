using UnityEngine;
using System.Collections;

public class CapsuleRotation : MonoBehaviour 
{
	public float Rotationspeed;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(Rotationspeed, 0, 0);
	}
		

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player")
		{
			Destroy (this.gameObject);
			Debug.Log ("Recieved some HP!!");
		
		}


	}


}
