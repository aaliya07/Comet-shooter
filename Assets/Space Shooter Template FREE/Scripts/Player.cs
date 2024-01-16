using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>

public class Player : MonoBehaviour
{
    public GameObject destructionFX;

    public static Player instance; 

    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }

    //method for damage processing by 'Player'
    public void GetDamage(int damage)   
    {
        Destruction();
    }    

    //'Player's' destruction procedure
    void Destruction()
    {
        Instantiate(destructionFX, transform.position, Quaternion.identity); //generating destruction visual effect and destroying the 'Player' object
        ScoreManager.instance.AddPoints(-10); // Subtract 10 points when the player is destroyed
        Destroy(gameObject); // Destroy the player object
    }

    // Called when the player collides with an enemy
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            ScoreManager.instance.AddPoints(5); // Increase score by 5 when colliding with an enemy
            Destroy(collision.gameObject); // Destroy the enemy object
        }
    }
}

















