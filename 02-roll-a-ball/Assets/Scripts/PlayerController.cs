using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declare variables
    Rigidbody rb;
    public float velocity;

    // Awake code
    private void Awake()
    {
        // Get Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Fixed Update code
    private void FixedUpdate()
    {
        // Get movements
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movHorizontal, 0f, movVertical);

        // Edit forces
        rb.AddForce(movement * velocity);
    }
}
