using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AudioSync : MonoBehaviour {
    //Video
    private VideoPlayer videoPlayer;

    //Audio
    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        videoPlayer = gameObject.GetComponent<VideoPlayer>();
        audioSource = gameObject.GetComponent<AudioSource>();

        Application.runInBackground = true;
        StartCoroutine(playAudio());
    }

    // Update is called once per frame
    IEnumerator playAudio() {
        videoPlayer.Prepare();

        //Wait until video is prepared
        while (!videoPlayer.isPrepared)
        {
            //Debug.Log("Preparing Video");
            yield return null;
        }

        //Debug.Log("Done Preparing Video");

        //Play Sound
        audioSource.Play();

        yield return new WaitForSeconds(0.3f);

        //Play Video
        videoPlayer.Play();

        //Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            //Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }

        //Debug.Log("Done Playing Video");
    }
}
