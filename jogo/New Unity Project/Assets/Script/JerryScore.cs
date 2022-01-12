using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryScore : MonoBehaviour
{
    private int score;
    private TextMesh texto;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        texto = GameObject.Find("ContadorPontos").GetComponent<TextMesh>();
        texto.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void incrementar(int valor)
    {
        score = score + valor;
        texto.text = "" + score;
    }
    public void decrementar(int valor)
    {
        score = score - valor;
        texto.text = "" + score;
    }
}
