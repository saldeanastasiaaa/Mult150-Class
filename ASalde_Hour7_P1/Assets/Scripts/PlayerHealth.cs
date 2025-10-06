using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 1004
        int poisonDamage = 125.5
        Debug.Log ("Current Health: " + health");
        health -= poisonDamage;
        Debug.Log ("Current Health: " + health);
        health -= poisonDamage;
        Debug.Log ("Current Health: " + health);
        health -= poisonDamage;
        Debug.Log ("Current Health: " + health);
        health -= poisonDamage;
        Debug.Log ("Current Health: " + health);
        Debug.Log ("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
