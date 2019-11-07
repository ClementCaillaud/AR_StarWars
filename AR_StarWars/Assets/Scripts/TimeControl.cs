using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Pause();
    }

    public void Play()
    {
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Wait(float seconds)
    {
        StartCoroutine(Waiting(seconds));
    }

    private IEnumerator Waiting(float seconds)
    {
        Pause();
        float pauseEndTime = Time.realtimeSinceStartup + seconds;
        while(Time.realtimeSinceStartup < pauseEndTime)
        {
            yield return 0;
        }
        Play();   
    }
}
