using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Declare variables
    public GameObject player;
    private Vector3 posRelative;

    // Start code
    private void Start()
    {
        // Get the initial camera relative position from the player transform relative position 
        posRelative = transform.position - player.transform.position;
    }

    // Late Update code
    private void LateUpdate()
    {
        // Updating the camera relative position from the current player transform relative position
        transform.position = player.transform.position + posRelative;
    }
}
