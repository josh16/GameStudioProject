using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
	
	//Bullet Variables
	public GameObject bullet;
    public float delayTime = 8f;
    private float counter = 0;
  
    // Use this for initialization
    void Start ()
    {
   
    }
	
	// Update is called once per frame
	void FixedUpdate () 
	{
	    if(Input.GetKey(KeyCode.Mouse0) && counter > delayTime)
        {
            Instantiate(bullet, transform.position, transform.rotation);
			counter = 0;
            //audio will play
            //audio.Play();
            //setting counter to zero again
         }
			counter += Time.deltaTime;
    }

   

    void Update()
    {
      

    }
}
