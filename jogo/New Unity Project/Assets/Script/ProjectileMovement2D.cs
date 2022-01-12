using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement2D : MonoBehaviour
{
    public float velocidade, tempodevida;
    private float tempoinicial;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(velocidade, 0);
        tempoinicial = Time.time;
        if (transform.rotation.eulerAngles.y == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidade, 0);
        } else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidade, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float tempoatual = Time.time;
        if (tempoatual - tempoinicial >= tempodevida)
        {
            Destroy(this.gameObject);
        }
    }
}
