using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterDamage : MonoBehaviour
{
 
    //movement
    public float speed = 10f;
    private Rigidbody rb;
    //
 
    //damage
    public HealthBar healthBar; 
    public int playerHealth = 3;
    public GameObject player;
    //
    

    void Start()
    {
        healthBar.SetMaxHealth(playerHealth);  
    }

    
    private void OnCollisionEnter(Collision col)  
    {
        
        if (col.gameObject == player)  
        {
            Debug.Log("Monster collided with the player!");
            playerHealth -= 1;  // Reduce health by 1
            healthBar.SetHealth(playerHealth);  // Update the health bar
        }
    }
}
