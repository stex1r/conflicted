using System;
using UnityEngine;

public class TickerOnSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("awoken ticking script for sphere");
        InvokeRepeating("timerSet", 0.1f,3.0f);
    }

    public void timerSet()
    {
        Debug.Log($"tick: {DateTime.Now}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
