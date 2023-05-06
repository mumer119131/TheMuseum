using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public float clickDistance = 100f;
    public LayerMask clickableLayerMask;

    private RectTransform cursorTransform;

    void Start() {
        cursorTransform = GetComponent<RectTransform>();

    // Set the position of the cursor to the center of the screen
        cursorTransform.position = new Vector2(Screen.width / 2f, Screen.height / 2f);
    }


    void Update() {
    
    // Check if the left mouse button was clicked
    if (Input.GetMouseButtonDown(0)) {
    //     // Get the current mouse position
        Vector2 mousePosition = Input.mousePosition;

        
    //     // Cast a ray from the mouse position to the clickable layer
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        Debug.Log(ray);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, clickDistance, clickableLayerMask)) {
    //         // If the ray hit a clickable object, play the click sound and trigger an event
            
           PlayAudioClip playAudioClip = hit.collider.GetComponent<PlayAudioClip>();
           Debug.Log(playAudioClip);
            if (playAudioClip != null) {
                playAudioClip.OnClicked();
            }
            }
        }
    }
}
