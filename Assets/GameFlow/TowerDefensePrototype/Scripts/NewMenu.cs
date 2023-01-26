using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class NewMenu : MonoBehaviour
{   
    public VideoPlayer VideoPlayer;
    public string SceneName ;     
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer.loopPointReached += LoadScene;
    }

    // Update is called once per frame
    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene( SceneName );
    }
}
