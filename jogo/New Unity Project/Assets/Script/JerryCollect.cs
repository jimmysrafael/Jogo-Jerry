using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Coletavel")
        {
            string tipo = col.GetComponent<Collectable>().tipo;
            if (tipo == "hp")
            {
                GetComponent<JerryHP>().incrementar();
                Destroy(col.gameObject);
            }
            if (tipo == "score")
            {
                GetComponent<JerryScore>().incrementar(50);
                Destroy(col.gameObject);
            }
        }
    }
}
