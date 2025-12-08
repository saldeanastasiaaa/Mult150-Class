using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Assign your street lamp prefab in the Unity Inspector
    public GameObject prefab;

    void Start()
    {
        // Loop 10 times to instantiate 10 street lamps
        for (int i = 0; i < 10; i++)
        {
            // Instantiate the prefab at the current object's position and rotation
            // They will all stack up in the exact same location
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }

    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Note: Instantiate() without position/rotation uses the prefab's original stored position/rotation
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}