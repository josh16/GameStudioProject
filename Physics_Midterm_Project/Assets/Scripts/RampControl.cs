using UnityEngine;
using System.Collections;

public class RampControl : MonoBehaviour 
{
	public float MoveSpeed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		RampC ();
	}

	void RampC()
	{
		if(Input.GetKeyDown(KeyCode.DownArrow)) 
		{
			transform.Translate (Vector3.down* Time.deltaTime);
			Debug.Log("MOVE DOWN!!!!!");
		}

		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up * Time.deltaTime);
			Debug.Log("MOVE UP!!!");
		}
	
	
		if(Input.GetKeyDown(KeyCode.O))
		{
			transform.Rotate(0,0,3);
			Debug.Log("Rotate Right");
		}
	

		if(Input.GetKeyDown(KeyCode.P))
		{
			transform.Rotate(0,0,-3);
			Debug.Log("Rotate Left");
		}
	}
}
