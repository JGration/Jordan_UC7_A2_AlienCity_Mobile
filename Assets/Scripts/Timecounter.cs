using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecounter : MonoBehaviour {

    public static float timeLeft = 40.0f;
    public Text time;
    void Start()
    {
        time = GetComponent<Text>();
        timeLeft = 40.0f;
    }
    void Update()
    {
        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
        }
        time.text = "Time: " + (int)timeLeft + "s";
    }
}
