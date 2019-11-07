using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : DefaultTrackableEventHandler
{
    public GameObject game;

    protected override void OnTrackingFound()
    {
        game.GetComponent<TimeControl>().Play();
    }

    protected override void OnTrackingLost()
    {
        game.GetComponent<TimeControl>().Pause();
    }
}
