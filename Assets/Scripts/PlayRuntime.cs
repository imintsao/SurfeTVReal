using UnityEngine;
using UnityEngine.Video;

public class PlayRuntime : MonoBehaviour
{
    private VideoPlayer MyVideoPlayer;

    private void Start()
    {
        MyVideoPlayer = GetComponent<VideoPlayer>();
        // play video player
        MyVideoPlayer.Play();
    }
}