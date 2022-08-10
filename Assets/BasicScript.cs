using System;
using UnityEngine;

public class BasicScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("awoken basic script");
        InvokeRepeating("timerSet", 1.0f,1.0f);
    }

    public void timerSet()
    {
        Debug.Log($"tick: {DateTime.Now}");
    }
}
