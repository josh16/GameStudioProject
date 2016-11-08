using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Add this to access the UI in unity.
using UnityStandardAssets.Characters.FirstPerson; // Add this directive to access specific scripts

public class PlayerHealth : MonoBehaviour 
{

	//Health variables, and damage
	public float StartingHealth = 100.0f;
	public float CurrentHealth;
	public Slider HealthSlider;
	public Image damageImage;
	public float HP;
    public float flashSpeed = 5.0f;
	public Color flashColour = new Color (1.0f, 0.0f, 0.0f, 1.0f); //Colour red

    //public AudioClip getHit;
    
    //Damage and dead booleans
	bool IsDead;
	bool Damaged;
	bool RecieveHealth;
	
	 FirstPersonController playerMovement;

	// Use this for initialization
	void Awake () 
	{
		playerMovement = GetComponent<FirstPersonController>();
		CurrentHealth = StartingHealth; 
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if (Damaged) 
		{
			damageImage.color = flashColour;
            //AudioSource.PlayClipAtPoint(getHit, transform.position);
		} 
		else 
		{
			damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime); 
		}

		Damaged = false; //Set Damaged as false

	}


	public void TakeDamage(int amount) // Made it public so other scripts can access it.
	{
		Damaged = true; //Damage is true because the player is taking damage.

		CurrentHealth -= amount; // applying the amount of damgae to the players currenthealth.

        //playerAudio.Play();

        HealthSlider.value = CurrentHealth; //Slider value will change to what the players current health is.

		//Audio sound
		//playerAudio.play();

		
		if (CurrentHealth <= 0 && !IsDead) 
		{
            //Destroy this gameobject and play an animation before it or start a couroutine???something..
            Death();
        }
		
	}





	void OnTriggerEnter(Collider other)
	{
		
		if (CurrentHealth < 100) 
		{

			if (other.gameObject.tag == "HealthPickup")
			{
				CurrentHealth += HP;
				Debug.Log ("Recieved some HP!!");
				HealthSlider.value = CurrentHealth;
			}


		}


	}







    void Death()
    {
        //playerAudio.Play();
        playerMovement.enabled = false;
    }

}
