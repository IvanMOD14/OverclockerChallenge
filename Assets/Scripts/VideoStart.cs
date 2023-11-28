using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoStart : MonoBehaviour
{
    public GameObject videoObject;
    public VideoPlayer videoPlayer;

    private void Start()
    {
        videoObject.SetActive(false);
    }

    public void StartVideo()
    {
        videoObject.SetActive(true);
        videoPlayer.Play();
    }
}
