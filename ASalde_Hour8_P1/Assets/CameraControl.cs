using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraTranslation : MonoBehaviour
{
    public float sensitivity = 0.5f; // Adjust this value to control translation speed

    void Update()
    {
        // Get mouse input for X and Y axes
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calculate translation vector based on mouse input and sensitivity
        // Translate right/left (X-axis) based on mouseX
        // Translate up/down (Y-axis) based on mouseY
        // Using transform.right and transform.up ensures movement is relative to the camera's orientation
        Vector3 translation = (transform.right * mouseX + transform.up * mouseY) * sensitivity * Time.deltaTime;

        // Apply the translation to the camera's position
        transform.Translate(translation, Space.World);
    }
}
