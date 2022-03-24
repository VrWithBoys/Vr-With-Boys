using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Networking;
using Mirror;

[System.Serializable]
public struct VideosToPlay
{
    public VideoClip video;
    public double currentTime;
}

public class CinemaManager : NetworkBehaviour
{
    public VideosToPlay[] videos;
    public AudioSource speakerSource;
    VideoPlayer videoPlayer;
    int currentCount = 0;
public GameObject videoObj;
public float playSpeed;
public bool start;
[SyncVar]
public double videoTime;
public double difference;
    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.targetTexture.Release();
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, speakerSource);
    }

    private void Update()
    {

        if (isServer) {
videoTime = videoObj.GetComponent<VideoPlayer> ().time;
}
if (!isServer) {
if (start && videoTime != 0) {
videoObj.GetComponent<VideoPlayer> ().time = videoTime;
start = false;
}
difference = videoObj.GetComponent<VideoPlayer> ().time - videoTime;
if (difference > 0.1f) {
videoObj.GetComponent<VideoPlayer> ().playbackSpeed = 0.8f;
} else if (difference < 0.1f) {
videoObj.GetComponent<VideoPlayer> ().playbackSpeed = 1.2f;
} else {
videoObj.GetComponent<VideoPlayer> ().playbackSpeed = 1f;
}
}
            if (Input.GetKeyDown(KeyCode.N))
            {
                videos[currentCount].currentTime = videoPlayer.time;
                currentCount += 1;
                if (currentCount == videos.Length)
                {
                    currentCount = 0;
                }
                PlayVideo();
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                videos[currentCount].currentTime = videoPlayer.time;
                if (currentCount == 0)
                {
                    currentCount = videos.Length - 1;
                }
                else
                {
                    currentCount -= 1;
                }
                PlayVideo();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (videoPlayer.isPlaying)
                {
                    videoPlayer.Pause();
                }
                else
                {
                    videoPlayer.Play();
                }
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (!videoPlayer.isPlaying)
                {
                    PlayVideo();
                }
                else
                {
                    videoPlayer.Stop();
                    videoPlayer.targetTexture.Release();
                }
            }
    }

    void PlayVideo()
    {
        videoPlayer.clip = videos[currentCount].video;
        videoPlayer.time = videos[currentCount].currentTime;
        videoPlayer.Play();
    }
}