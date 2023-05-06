using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;

    public GameObject popupPanel;

    public GameObject cursorPanel;

    void Start(){

        popupPanel.SetActive(false);
        cursorPanel.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        //If escape button is pressed, transition to escape menu

        transitionToEscapeMenu();

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

    void transitionToEscapeMenu(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Cursor.lockState = CursorLockMode.None;
            popupPanel.SetActive(true);
            cursorPanel.SetActive(false);
        }
    }
}
