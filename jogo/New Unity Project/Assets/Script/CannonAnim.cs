using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAnim : MonoBehaviour
{
    public string nome;
    private GameObject alvo;

    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.Find(nome);
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaX, distanciaY, angulo;
        distanciaX = transform.position.x - alvo.transform.position.x;
        distanciaY = transform.position.y - alvo.transform.position.y;
        angulo = Mathf.Atan(distanciaY / distanciaX);
        angulo = angulo * Mathf.Rad2Deg;
        if (distanciaX>0)
        {
            angulo += 180;
        }
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angulo));
    }
}
