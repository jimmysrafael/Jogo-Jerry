using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int hp;
    public float tempoinvulneravel;
    private float ultimodano;
    private bool podeseratingido;
    public GameObject[] partescoloridas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - ultimodano >= tempoinvulneravel && podeseratingido == false)
        {
            podeseratingido = true;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            for (int i = 0; i < partescoloridas.Length; i++)
            {
                partescoloridas[i].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "tirojerry" && podeseratingido)
        {
            hp--;
            Destroy(col.gameObject);
            GetComponent<SpriteRenderer>().color = new Color(1f, 0.3f, 0.3f);

            for (int i = 0; i < partescoloridas.Length; i++)
            {
                partescoloridas [i].GetComponent<SpriteRenderer>().color = new Color(1f, 0.3f, 0.3f);
            }
        }
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
        ultimodano = Time.time;
        podeseratingido = false;
    }
}
