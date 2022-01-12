using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiProjectile2D : MonoBehaviour
{
    public float velocidade, tempodevida;
    private float tempoinicial;
    // Start is called before the first frame update
    void Start()
    {
        tempoinicial = Time.time;
        float velocidadeX, velocidadeY;
        float anguloradianos;
        anguloradianos = transform.eulerAngles.z * Mathf.Deg2Rad;
        velocidadeX = Mathf.Cos(anguloradianos) * velocidade;
        velocidadeY = Mathf.Sin(anguloradianos) * velocidade;
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeX, velocidadeY);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - tempoinicial >= tempodevida)
        {
            Destroy(gameObject);
        }
    }
}
