using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryHP : MonoBehaviour
{
    public int hp;
    public float tempoinvulneravel;
    private float ultimodano;
    private bool podeseratingido;
    public GameObject coracao;
    private Vector3 posicao;
    // Start is called before the first frame update
    void Start()
    {
        podeseratingido = true;
        ultimodano = Time.time;
        posicao = GameObject.Find("hpoffset").transform.position;
        GameObject aux;
        for (int i = 0; i < hp; i++)
        {
            aux = (GameObject)Instantiate(coracao, new Vector3(posicao.x + (i * 0.5f), posicao.y, posicao.z + 1), transform.rotation);
            aux.transform.parent = GameObject.Find("Main Camera").transform;
            aux.name = "coracao" + i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - ultimodano >= tempoinvulneravel && podeseratingido == false)
        {
            podeseratingido = true;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (podeseratingido)
        {
            if (col.tag == "tiroinimigo")
            {
                hp--;
                Destroy(GameObject.Find("coracao" + hp));
                Destroy(col.gameObject);
                GetComponent<SpriteRenderer>().color = new Color(1f, 0.3f, 0.3f);
                podeseratingido = false;
                ultimodano = Time.time;
                if (hp<= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
    public void incrementar()
    {
        GameObject aux;
        aux = (GameObject)Instantiate(coracao, new Vector3(posicao.x + (hp * 0.5f), posicao.y, posicao.z + 1), transform.rotation);
        aux.transform.parent = GameObject.Find("Main Camera").transform;
        aux.name = "coracao" + hp;
        hp++;
    }
    public void decrementar()
    {
        hp--;
        Destroy(GameObject.Find("coracao" + hp));
    }
}
