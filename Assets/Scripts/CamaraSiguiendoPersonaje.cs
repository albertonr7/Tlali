using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Por: Alberto
// Código para que la camara siga al personaje
public class CamaraSiguiendoPersonaje : MonoBehaviour
{

    // El objeto al que sigue la camara y el espacio minimo y maximo en el que se puede mover la camara
    public GameObject personaje;
    public Vector2 minimoCam, maximoCam;
    // Retardo del movimiento de la camara
    public float smoothTime;
    // Velocidad de la camara
    private Vector2 velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // FixedUpdate es llamada en cada frame del juego
    void FixedUpdate()
    {
        // Valores de posición del personaje
        float posX = Mathf.SmoothDamp(transform.position.x, personaje.transform.position.x, ref velocidad.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, personaje.transform.position.y, ref velocidad.y, smoothTime);
        // Actualizando los valores de posición de la camara
        transform.position = new Vector3(
            Mathf.Clamp(posX, minimoCam.x, maximoCam.x),
            Mathf.Clamp(posY, minimoCam.y, maximoCam.y),
            transform.position.z);
    }
}
