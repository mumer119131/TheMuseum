using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    
    public GameObject popupPanel;
    public GameObject cursorPanel;

    public void resumeGame(){
        popupPanel.SetActive(false);
        cursorPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void exitToMainMenu(){
        int main_menu = 1;
        SceneManager.LoadScene(main_menu);
    }

    public void quiteGame(){
        Application.Quit();
    }

}
