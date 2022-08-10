using System;
using UnityEngine;

public class TickerOnSphere : MonoBehaviour
{
    // f-3 line added
    private bool first = true;
    void Start()
    {
        InvokeRepeating("TimerSet", 1.0f,1.0f); // line from main (fixed)
        Invoke("DisableTicker", 10.0f); // f-2 line
    }

    public void TimerSet()
    {
        // updated on f-3
        Debug.Log($"tick-tock: {DateTime.Now}"); // this line on f-3 is modified
    }

    /*
     * f-2 method
     */
    public void DisableTicker()
    {
        /*
         * f-3 part
         */
        if (first)
        {
            first = !first;
            Debug.Log($"what should I do?...let's wait more ({3.0f} seconds)");
            Invoke("DisableTicker", 3.0f); // f-3 line
            return;
        }
        CancelInvoke("TimerSet");
        Debug.Log($"for now, timer killed at: {DateTime.Now}"); // f-3 modified
    }
}
