using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CrawlerHealth : MonoBehaviour
{
    //Crawlers health vars
    //public float StartingHealth = 100.0f;
    public float CurrentHealth = 100.0f;

    //public Image HealthBar;
    public Slider HealthSliderEnemy;

    //Booleans
    // bool IsDead;
    //bool Damaged;


    // public Crawler crawlerMovement;

    //amount of damage player does to crawler health
    public float BulletDamage = 3.0f;
    public float GrenadeDmg = 10.0f;



    void Start()
    { 
    }
 

    void Update()
    {

    }
	
    void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            CurrentHealth -= BulletDamage;
            Debug.Log("BulletHit!");
           HealthSliderEnemy.value = CurrentHealth;
        }

        if(collision.gameObject.CompareTag("Grenade"))
        {
            CurrentHealth -= GrenadeDmg;
            Debug.Log("Grenade Hit!");
            HealthSliderEnemy.value = CurrentHealth;
        }

      
    }
}
