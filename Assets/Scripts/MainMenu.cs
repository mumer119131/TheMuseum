using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    int levels_menu = 2;
    
    public void transitionToLevelsMenu(){

        SceneManager.LoadScene(levels_menu);

    }

    public void exitGame(){

        Application.Quit();

    }
}
