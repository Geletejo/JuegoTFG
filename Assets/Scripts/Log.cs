using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : Enemigo {

    public Transform objetivo;
    public float radioSeguir;
    public float radioAtaque;
    public Transform posicionOriginal;

    // Start is called before the first frame update
    void Start()
    {
        objetivo = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        if(Vector3.Distance(objetivo.position, transform.position) <= radioSeguir)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo.position, radioAtaque);
        }
    }
}
