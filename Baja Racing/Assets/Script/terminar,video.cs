using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class HideVideoOnEnd : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Button botonSalir;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.Play();

        botonSalir.gameObject.SetActive(false); 
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        botonSalir.gameObject.SetActive(true); 
        gameObject.SetActive(false); 
    }
}