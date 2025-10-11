using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    void Start()
    {
        // Loop from 22 to 100, incrementing the counter by 2 each time
        for (int i = 22; i <= 100; i += 2)
        {
            Debug.Log(i);
        }
    }
}

