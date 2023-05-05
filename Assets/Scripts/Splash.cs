using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    public float delayTime = 2.0f;
    public string nextSceneName = "Level 1";

    void Start(){
        Invoke("LoadSplash", delayTime);
    }
    // Update is called once per frame
    void LoadSplash(){
        SceneManager.LoadScene(nextSceneName);
    }
}
