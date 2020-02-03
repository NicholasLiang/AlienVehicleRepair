using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer vp = GetComponent<VideoPlayer>();
        vp.loopPointReached += startloadScene;

    }
    void startloadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);
    }
}
