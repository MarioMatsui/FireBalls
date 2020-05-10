using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnClick : MonoBehaviour
{
    public AudioSource ClickSFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;

    public void HoverSound(){
        ClickSFX.PlayOneShot(hoverFX);
    }
    public void ClickSound(){
        ClickSFX.PlayOneShot(clickFX);
    }

}
