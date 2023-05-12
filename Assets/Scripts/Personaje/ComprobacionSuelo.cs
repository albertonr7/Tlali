using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Por: Alberto Nieto Rocha
//Script para comprobar si el personaje esta tocando el suelo o una plataforma.
public class ComprobacionSuelo : MonoBehaviour
{

    private Controles personaje;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GetComponentInParent<Controles>();
        rb2d = GetComponentInParent<Rigidbody2D>();
    }

    // Al subir a la platafor ponemos la velocidad del personaje en 0.
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "PlataformaMovil"){
            rb2d.velocity = new Vector3(0f, 0f, 0f);
            personaje.transform.parent = col.transform;
            personaje.suelo = true;
        }
    }


    // Comprobar si estamos chocando contra una plataforma o cualquier otro objeto. 
    void OnCollisionStay2D(Collision2D col){
        if(col.gameObject.tag == "plataforma"){
            personaje.suelo = true;
        }
        if(col.gameObject.tag == "PlataformaMovil"){
            personaje.transform.parent = col.transform;
            personaje.suelo = true;
        }
    }

    void OnCollisionExit2D(Collision2D col){
        if(col.gameObject.tag == "plataforma"){
            personaje.suelo = false;
        }
        if(col.gameObject.tag == "PlataformaMovil"){
            personaje.transform.parent = null;
            personaje.suelo = false;
        }
    }

}
