using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public AudioSource ClickSFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;
    public Image pause;
    public Sprite pausado;
    public Sprite despausado;
    bool isPaused = false;
    // Start is called before the first frame update
    public void PauseGame(){
        if(isPaused){
            Time.timeScale = 1;
            isPaused = false;
            pause.sprite = despausado;
        } else{
            Time.timeScale = 0;
            isPaused = true;
            pause.sprite = pausado;
        }
    }
    public void HoverSound(){
        ClickSFX.PlayOneShot(hoverFX);
    }
    public void ClickSound(){
        ClickSFX.PlayOneShot(clickFX);
    }
}
