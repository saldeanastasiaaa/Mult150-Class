using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Adjust the speed and axis in the Inspector
    public Vector3 rotationSpeed = new Vector3(0, 50, 0);

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its own axes
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
