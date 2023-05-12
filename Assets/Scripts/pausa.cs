using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Por: Alberto Nieto Rocha
// Script para activar o desactivar el menú de pausa.
public class pausa : MonoBehaviour
{

    bool activo;
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Activar/desactivar pausa, cambiar el reloj del juego para que se pause todo.
    void Update()
    {

    }

    // Si el menú esta activo el tiempo es pausado (0) sino el tiempo se queda normal. 
    public void pausar(){
        activo = !activo;
        canvas.enabled = activo;
        Time.timeScale = (activo) ? 0 : 1f;
    }

    public void salir(string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
    }

    public void continuar(){
        activo = !activo;
        canvas.enabled = activo;
        Time.timeScale = (activo) ? 0 : 1f;
    }


}
