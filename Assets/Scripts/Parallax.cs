using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Realizado por: Alberto Nieto Rocha
// el efecto parallex se aplica en el fondo de las escenas,
// con este podemos cotrolar que las distintas capas se muevan a diferentes velocidades.
public class Parallax : MonoBehaviour
{

    private float longitud, posInicial;
    public GameObject camara;
    public float efectoParallax;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position.x;
        longitud = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (camara.transform.position.x * (1 - efectoParallax));
        float distancia = (camara.transform.position.x * efectoParallax);
        
        transform.position = new Vector3(posInicial + distancia, transform.position.y, transform.position.z);

        if (temp > posInicial + longitud) posInicial += longitud;
        else if(temp < posInicial - longitud) posInicial -= longitud;
    }
}
