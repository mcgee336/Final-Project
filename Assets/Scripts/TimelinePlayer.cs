using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{
    private PlayableDirector director;
    public GameObject controlPanel;



    public void Awake()
    {
        director = GetComponent<PlayableDirector>();
    }

    public void StartTimeline()
    {
        director.Play();
    }


}
