using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Declare variables
    private Rigidbody rb;
    private int currentScore;
    public Text score;
    public Text winMessage;
    public float velocity;

    // Awake code
    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody
        currentScore = 0; // Initial points
        winMessage.gameObject.SetActive(currentScore >= 12); // Disabled win message
        UpdateScorePoints(); // Initial text score
    }

    // Update code
    private void Update()
    {
        // Game exit in case you press escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
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

    // Trigger that is executed in case of entering an object
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Destroy points
        currentScore++; // Adding points
        UpdateScorePoints(); // Updating score text
    }

    // Update score point
    private void UpdateScorePoints()
    {
        score.text = "Score: " + currentScore; // Update score point text
        winMessage.gameObject.SetActive(currentScore >= 12); // Enable the win message in case you have 12 or more
    }
}
