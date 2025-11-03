using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int collisionCount = 0;
    private const string sphereTagName = "Sphere"; // Tag the sphere object as "Sphere" in the Inspector

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the sphere
        if (collision.gameObject.CompareTag(sphereTagName))
        {
            collisionCount++;
            Debug.Log("Sphere has collided with the cube " + collisionCount + " times.");
        }
    }
}
