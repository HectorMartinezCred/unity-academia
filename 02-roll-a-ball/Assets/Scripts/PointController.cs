using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    //Declare variable
    private Vector3 rotation = new Vector3(15f, 30f, 45f); // Rotation parameters

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(rotation * Time.deltaTime); // Rotate point per second
    }
}
