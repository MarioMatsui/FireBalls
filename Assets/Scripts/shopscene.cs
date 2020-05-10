using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shop_scene : MonoBehaviour
{
    public void shop(){
        SceneManager.LoadScene(1);
    }
    public void BackToGame(){
        SceneManager.LoadScene(0);
    }
}
