using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // The Start() method is called once when the script is enabled.
    void Start()
    {
        // Set your birthday day here 13th.
        int birthdayDay = 13;

        // The number of days in August is 31.
        int daysInAugust = 31;

        // Loop through each day of the month.
        for (int day = 1; day <= daysInAugust; day++)
        {
            // Check if the current day is your birthday.
            if (day == birthdayDay)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }
}
