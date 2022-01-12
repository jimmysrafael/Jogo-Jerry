using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2dController : MonoBehaviour
{
    private Rigidbody2D rgd;
    public float velocidade;
    public float velocidadepulo;
    private bool nochao, podepuloduplo;
    public Transform checarchao;
    public LayerMask chao;
    public GameObject projetil;
    public float recarga;
    private float ultimotiro;
    private Animator anim;
    void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
        ultimotiro = Time.time;
        anim = GetComponent<Animator>();

    }

    
    void Update()
    {
        //controle do movimento x
        float x = Input.GetAxisRaw("Horizontal");
        if (x < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        } 
        if (x > 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        rgd.velocity = new Vector2(x*velocidade,rgd.velocity.y);
        //controle do pulo
        nochao = Physics2D.OverlapCircle(checarchao.position, 0.2f, chao);
        anim.SetBool("nochao", nochao);
        //controle do movimento y
        if (nochao)
        {
            podepuloduplo = true;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (nochao)
            {
                rgd.velocity = new Vector2(rgd.velocity.x, velocidadepulo);
            } else
            {
                if (podepuloduplo)
                {
                    rgd.velocity = new Vector2(rgd.velocity.x, velocidadepulo);
                    podepuloduplo = false;
                }
            }
            
        }
        //controle de disparos
        if (Input.GetKey(KeyCode.F))
        {
            if (Time.time - ultimotiro >= recarga)
            {
                Instantiate(projetil, transform.position, transform.rotation);
                ultimotiro = Time.time;
            }
        }
    }
}
