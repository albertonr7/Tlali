using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Por: Alberto Nieto Rocha
// Se dibuja una linea desde las plataformas moviles hasta su objetivo, esta linea solo es una guia para 
// los desarrolladores
public class DibujarLinea : MonoBehaviour
{

    public Transform desde;
    public Transform destino;

    // Dinujar una línea al mover el elemento
    void OnDrawGizmosSelected(){
        if(desde != null && destino != null){
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(desde.position, destino.position);
        }
    } 

}
