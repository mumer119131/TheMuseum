using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsMenu : MonoBehaviour
{

    int level_1 = 3;
    int level_2 = 4;

    public Outline outline;
    public Text level_text;

    void Start() {
        
        outline = GetComponent<Outline>();

    }


    public void playLevel1(){

        changeButtonEffect();
        SceneManager.LoadScene(level_1);

    }

    public void playLevel2(){

        changeButtonEffect();
        SceneManager.LoadScene(level_2);
    }

    void changeButtonEffect(){
        outline.effectColor = Color.green;
        level_text.color = Color.green;
    }
}
