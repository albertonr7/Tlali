using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Realizado por: ALberto Nieto Rocha
// Con esté código se controla la caida y reaparición de las plataformas.
public class PlataformaMovil : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad;

    private Vector3 inicio, final;


    // Start is called before the first frame update
    // Evitar que el objetivo se mueva junto con la plataforma, decimos que el objetivo ya no es hijo de la plataforma.
    void Start()
    {
        if(objetivo != null){
            objetivo.parent = null;
            // Guardamos la posición inicial y final de la plataforma.
            inicio = transform.position;
            final = objetivo.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Mover la plataforma al objetivo.
    void FixedUpdate(){
        if(objetivo != null){
            float velocidadPerfecta = velocidad * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidadPerfecta);
        }

        // Si la posición final es igual al principio cambiamos el objetivo a la posición final, sino dejamos la posición al principio. 
        if(transform.position == objetivo.position){
            objetivo.position = (objetivo.position == inicio) ? final : inicio;
        }

    }
}
