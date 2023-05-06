using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClip : MonoBehaviour
{

    public AudioClip audioClip;
    public AudioSource audioSource;
    bool isAudioPlaying = false;

    public void OnClicked(){
        audioSource.clip = audioClip;
        if(!isAudioPlaying){
            audioSource.Play();
            isAudioPlaying = true;
        }else{
            audioSource.Stop();
            isAudioPlaying = false;
        }   
    }
}
