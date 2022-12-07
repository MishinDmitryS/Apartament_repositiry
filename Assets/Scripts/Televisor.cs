using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Televisor : MonoBehaviour
{
    // Start is called before the first frame update
    private bool played;
    [SerializeField] private VideoClip videoClip;
    [SerializeField] private VideoPlayer videoPlayer;

    private void Start()
    {
        played = false;
        videoPlayer.SetDirectAudioVolume(0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartStopVideo()
    {
        if(!played)
        {
            videoPlayer.clip = videoClip;
            videoPlayer.SetDirectAudioVolume(0, 0.1f);
            played = true;
        } else
        {
            videoPlayer.clip = null;
            played=false;  
        }
    }
}
