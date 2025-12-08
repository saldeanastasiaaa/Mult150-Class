using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim; // Declare a variable to hold a reference to the Animator component

    void Start()
    {
        // Get a reference to the Animator component attached to the same GameObject
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Set the "Speed" parameter of the Animator based on the Vertical input axis
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        // Set the "Direction" parameter of the Animator based on the Horizontal input axis
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));
    }
}