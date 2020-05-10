using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraPonto : MonoBehaviour
{
    bool podecomecar = false;
    public float velocidade;

    // Update is called once per frame
    void Update()
    {
        if(podecomecar){
            transform.Translate(new Vector2(0f, velocidade * Time.deltaTime));
        }
    }
    public void ComecarPonto(){
        podecomecar = true;
    }
}
