using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public float tempoderecarga;
    private float ultimotiro;
    public GameObject projetil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - ultimotiro >= tempoderecarga)
        {
            Instantiate(projetil, transform.position, transform.rotation);
            ultimotiro = Time.time;
        }
    }
}
