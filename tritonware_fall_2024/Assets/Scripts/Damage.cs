using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage =1;
    public Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collsion){
        if (collsion.gameObject.tag == "Player"){
            playerHealth.TakeDamage(damage);
            
        }
    }
}
