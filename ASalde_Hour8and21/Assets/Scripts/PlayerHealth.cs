using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992; // Declared inside the class block, above Start()

    void Start()
    {
        // Calling UsePotion and updating healthpoints 4 times
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        Debug.Log("Zell's ending healthpoints: " + healthpoints); // Logging the final healthpoints
    }

    void Update()
    {
        // Update is not used in this example, but kept for context as it's a standard Unity method
    }

    // Function/method named UsePotion
    int UsePotion(int health)
    {
        health += 400; // Add 400 to health
        return health; // Return the result
    }
}