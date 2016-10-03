using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
   // public GameObject planet;
	public float Rotationspeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, Rotationspeed,0);
	}
}
