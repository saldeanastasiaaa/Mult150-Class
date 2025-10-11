using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Declare and assign the float variables
    float health = 1004f;
    float poisonDamage = 125.5f;
    // The Start method is called when the script is enabled
    void Start()
    {
        // Log the value of the 'health' variable to the console
        Debug.Log(health);
        // Log the initial health value
        Debug.Log("Initial health: " + health);
        // Subtract poisonDamage from health
        health -= poisonDamage;
        // Log the updated health value to the console a second time
        Debug.Log("Health after poison damage: " + health);
        health -= poisonDamage;
        Debug.Log("Health after poison damage: " + health);
        health -= poisonDamage;
        Debug.Log("Health after poison damage: " + health);
        health -= poisonDamage;
        Debug.Log("Health after poison damage: " + health);
        health -= poisonDamage;
        Debug.Log("Health after poison damage: " + health);
        health -= poisonDamage;
        Debug.Log("Health after poison damage: " + health);
        health -= poisonDamage;
        Debug.Log("Health after poison damage: " + health);
        health -= poisonDamage;
        Debug.Log("Health after poison damage: " + health);
        Debug.Log("Player has been unalived!");
    }
}

