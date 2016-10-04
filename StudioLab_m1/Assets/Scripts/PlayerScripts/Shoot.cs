using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float delayTime = 8f;

    private float counter = 0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if(Input.GetKey(KeyCode.Mouse0) && counter > delayTime)
        {
            Instantiate(bullet, transform.position, transform.rotation);

            //audio will play
            //audio.Play();
            //setting counter to zero again
            counter = 0;

           /*
            //Raycasting
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit,100f))
            {
                Instantiate()
            }
            */
        }

        counter += Time.deltaTime;
    }
}
