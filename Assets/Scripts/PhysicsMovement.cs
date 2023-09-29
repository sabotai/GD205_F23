using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{

    Rigidbody rb;
    public float forceMultiplier = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(transform.forward * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(-transform.forward * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(-transform.right * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(transform.right * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.LeftShift)){
            rb.velocity *= 0.95f;
        }
    }
}
