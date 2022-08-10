using System;
using UnityEngine;

public class TickerOnSphere : MonoBehaviour
{
    // f-3 line added
    private bool first = true;
    void Start()
    {
        InvokeRepeating("timerSet", 1.0f,1.0f); // line from main (fixed)
        Invoke("disableTicker", 10.0f); // f-2 line
    }

    public void timerSet()
    {
        // updated on f-3
        Debug.Log($"tick-tock: {DateTime.Now}"); // this line on f-3 is modified
    }

    /*
     * f-2 method. let's pretend it was changed during merge here ...
     */
    public void disableTicker()
    {
        /*
         * f-3 part
         */
        if (first)
        {
            first = !first;
            Debug.Log($"what should I do?...let's wait more ({3.0f} seconds)");
            Invoke("disableTicker", 3.0f); // f-3 line
            return;
        }
        CancelInvoke("timerSet");
        /* ...
            ...
                ...
                        ...
                                and here.
        */
        Debug.Log($"timer killed at: {DateTime.Now}"); // f-2 fix on review request
    }
}
