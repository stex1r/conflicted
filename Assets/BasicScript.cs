using System;
using UnityEngine;

public class BasicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("awoken basic script");
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
