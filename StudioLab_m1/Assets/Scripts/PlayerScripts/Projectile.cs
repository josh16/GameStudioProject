using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

  
    







    void Start () {
        //prefab = Resources.Load("Lazer") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        FireLazer();

    }

    
    void FireLazer()
    {
		

		//Rigidbody instantiatedLazer = Instantiate (Primary_Lazer, PrimaryTrans.position, PrimaryTrans.rotation) as Rigidbody;
		//instantiatedLazer.velocity = Primary_Lazer.transform.TransformDirection(new Vector3 (0,0, L_speed * Time.deltaTime));


	}
    
 

}
