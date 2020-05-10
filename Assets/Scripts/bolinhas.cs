using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolinhas : MonoBehaviour
{
    private Shake shake;
    public GameObject explosion;
    public RotacionarBola controlador;

    void Start(){
        shake = GameObject.FindGameObjectsWithTag("ScreenShake")[0].GetComponent<Shake>();
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if(colisor.gameObject.tag == "Ponto"){
            Destroy(colisor.gameObject);
            controlador.AtualizarPontuacao();
        }
        if(colisor.gameObject.tag == "plataforma"){
            shake.CamShake();
            Instantiate(explosion, transform.position, Quaternion.identity);
            controlador.ChamarGameOver();
        }
    }

}
