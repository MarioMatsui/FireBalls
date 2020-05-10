using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    bool isPaused;
    public AudioSource ClickSFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;
    public void PlayGame(){
        SceneManager.LoadScene(0);
    }
    public void PauseGame(){
        if(isPaused){
            Time.timeScale = 0;
            isPaused = false;
        } else{
            Time.timeScale = 1;
            isPaused = true;
        }
    }
    public void HoverSound(){
        ClickSFX.PlayOneShot(hoverFX);
    }
    public void ClickSound(){
        ClickSFX.PlayOneShot(clickFX);
    }
}
