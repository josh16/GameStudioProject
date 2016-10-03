using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{

    ///reference to character controller


    private CharacterController controller;

    //Variables for jumping
    private float VerticalVelocity;
    private float gravity = 14.0f;
    public float jumpforce = 10.0f;
    public float speed;
    private Vector3 MoveDirection = Vector3.zero;




    // Use this for initialization
    private void Start()
    {
		controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (controller.isGrounded)
        {


            
			//New stuff
			MoveDirection = new Vector3(Input.GetAxis ("Horizontal"), 0,Input.GetAxis("Vertical"));

			MoveDirection = transform.TransformDirection(MoveDirection);

			MoveDirection *= speed;

			if(Input.GetKeyDown(KeyCode.Space))
				{
					MoveDirection.y = jumpforce;
				}

            




            /*//holding the player down to the ground
			VerticalVelocity = -gravity * Time.deltaTime;

			if (Input.GetKeyDown(KeyCode.Space))
			{
				VerticalVelocity = jumpforce;
			}
		}
		else
		{
			// The player not be held down by gravity
			VerticalVelocity -= gravity * Time.deltaTime;
		}

		//Creating a vector 3 and vertical velocity is being set to "y"
		Vector3 moveVector = new Vector3(0,VerticalVelocity,0);
		controller.Move (moveVector * Time.deltaTime);
	



		//Vector3 moveVector = new Vector3(0, VerticalVelocity, 0);
		controller.Move(moveVector * Time.deltaTime);
	*/
        }
        //NewStuff
        MoveDirection.y -= gravity * Time.deltaTime;
        controller.Move(MoveDirection * Time.deltaTime);

        
    }
}