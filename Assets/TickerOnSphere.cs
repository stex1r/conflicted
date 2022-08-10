using System;
using UnityEngine;

public class TickerOnSphere : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("timerSet", 1.0f,1.0f); // line from main (fixed)
        Debug.Log("awoken ticking script for sphere"); // line from dependent (already has new logic)
    }

    public void timerSet()
    {
        Debug.Log($"tick: {DateTime.Now}");
    }
}
