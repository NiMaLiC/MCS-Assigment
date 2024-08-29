using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    public Rigidbody rb;
    public float forceAmount = 1f;

   
    // Start is called before the first frame update
    void Start()
    {
        // rb.AddForce(0,0,forwardForce*Time.deltaTime);
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Check for input and apply force accordingly
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceAmount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * forceAmount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * forceAmount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceAmount);
        }
    }

    
    
}
