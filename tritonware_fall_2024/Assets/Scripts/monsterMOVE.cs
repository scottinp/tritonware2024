using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterMOVE : MonoBehaviour
{
    // Reference to the monster object
    public GameObject Monster;

    // Speed of the monster movement
    public float speed = 10f;

    void Start()
    {
        // (Optional) Initialize any logic here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Move the monster smoothly over time
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
    }
}
