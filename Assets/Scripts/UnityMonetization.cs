using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityMonetization : MonoBehaviour
{
    string GooglePlay_ID = "3582129";
    bool GameMode = true;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GooglePlay_ID, GameMode);
    }

    public void DisplayInterstitialAD(){
        Advertisement.Show();
    }
}
