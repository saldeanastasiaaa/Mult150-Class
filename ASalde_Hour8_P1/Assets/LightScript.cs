using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb : MonoBehaviour
{
    private Light _myLight;

    void Start()
    {
        // Get the Light component attached to this GameObject
        _myLight = GetComponent<Light>();
    }

    void Update()
    {
        // Check if the 'L' key was pressed down this frame
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Toggle the enabled state of the Light component
            _myLight.enabled = !_myLight.enabled;
        }
    }
}
