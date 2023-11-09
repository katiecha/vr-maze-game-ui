using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Needs to countdown from a certain time = game duration
public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    void Start()
    {
        // Once the game starts, setting current time to starting time
        currentTime = startingTime;
    }

    void Update()
    {
        // currentTime -= 1 does by each frame...bad
        currentTime -= 1 * Time.deltaTime; // decreases by 1 each second instead
        print (currentTime);
    }
}
