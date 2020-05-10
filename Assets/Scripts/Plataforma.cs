using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(Mathf.PingPong(Time.time, 1), transform.localScale.y);
        transform.Translate(new Vector3(0f, velocidade * Time.deltaTime));
    }

}
