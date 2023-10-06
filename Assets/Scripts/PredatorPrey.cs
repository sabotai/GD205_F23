using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorPrey : MonoBehaviour
{

    Rigidbody rb;
    public Transform player;
    public float forceMultiplier = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        rb.AddForce(Vector3.Normalize(player.position - transform.position) * forceMultiplier); //insert the direction of the player multiplied to a force value
        //direction = destination - position
        //and then normalize that
    }
}
