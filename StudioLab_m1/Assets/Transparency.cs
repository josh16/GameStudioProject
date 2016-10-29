using UnityEngine;
using System.Collections;

public class Transparency : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<MeshRenderer>().material.color = new Color(0.0f, 1.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
