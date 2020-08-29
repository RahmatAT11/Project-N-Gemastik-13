using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    private int seconds = 305;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GameTimer", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameTimer()
    {
        Debug.Log(seconds);
        seconds--;
        if (seconds == 0)
        {
            Time.timeScale = 0;
        }
    }
}
