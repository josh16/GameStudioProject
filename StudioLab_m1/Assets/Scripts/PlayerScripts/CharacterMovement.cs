using UnityEngine;
using System.Collections;

public class CharacterMovement: MonoBehaviour {

   


	//public variables
	public float speedMov;
	//public float L_Speed;
  

    void start(){

   		//Mouse cursor
        Cursor.lockState = CursorLockMode.Locked;
	

	}
	
	// Update is called once per frame
	void Update ()
    {

		//Input axis for movement and Strafe
		float move = Input.GetAxis("Vertical") * speedMov;
		float Strafe = Input.GetAxis("Horizontal") * speedMov;

		//Multiply the axis by time.delta time
		move *= Time.deltaTime;
		Strafe *= Time.deltaTime;

		transform.Translate(Strafe, 0, move);

		//Escape input

		if (Input.GetKeyDown("escape"))
		{
			Cursor.lockState = CursorLockMode.None;
		}
       
       
    }
    



}