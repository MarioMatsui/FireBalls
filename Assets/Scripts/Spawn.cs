using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject PlataformaPrefab;

    bool podecomecar;
    float tempo;
    public float tempoMin;
    public float tempoMax;
    float tempoTotal;
    void Start()
    {
        tempoTotal = Random.Range(tempoMin, tempoMax);
    }

    // Update is called once per frame
    void Update()
    {
        if(podecomecar){
            tempo += Time.deltaTime;

            if(tempo >= tempoTotal){
                Instantiate(PlataformaPrefab, transform.position, transform.rotation);
                tempoTotal = Random.Range(tempoMin, tempoMax);
                tempo = 0f;
            }
        }
    }
    public void ComecarJogo(){
        podecomecar = true;
    }
}
