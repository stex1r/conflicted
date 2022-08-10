using System;
using UnityEngine;

public class TickerOnSphere : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("timerSet", 1.0f,1.0f); // line from main (fixed)
        Invoke("disableTicker", 10.0f); // f-2 line
        Debug.Log("awoken ticking script for sphere"); // line from dependent (already has new logic)
    }

    public void timerSet()
    {
        Debug.Log($"tick: {DateTime.Now}");
    }

    /*
     * f-2 method. let's pretend it was changed during merge here ...
     */
    public void disableTicker()
    {
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
