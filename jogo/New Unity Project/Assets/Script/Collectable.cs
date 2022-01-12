using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string tipo;
    public float tempoanimacao;
    public float velocidadeanimacao;
    private float auxanimacao;
    private Rigidbody2D rgd;
    // Start is called before the first frame update
    void Start()
    {
        auxanimacao = Time.time;
        rgd = GetComponent<Rigidbody2D>();
        rgd.velocity = new Vector2(0, velocidadeanimacao);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - auxanimacao >= tempoanimacao)
        {
            rgd.velocity = new Vector2(0, -rgd.velocity.y);
            auxanimacao = Time.time;
        }
    }
}
