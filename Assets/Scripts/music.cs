using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleSound(){
        if(PlayerPrefs.GetInt("Muted", 0) == 0){
            PlayerPrefs.SetInt("Muted", 1);
        }
        else {
            PlayerPrefs.SetInt("Muted", 0);
        }
    }
}
