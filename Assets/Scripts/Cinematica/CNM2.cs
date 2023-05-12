using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//guión escrito por Rebeca De la luz Elizalde y Andrea Dominguez
//funcionan básicamente igual las cinemáticas de la num 1 a la num 9 ya que primero se hace el string con la frase a mostrar 
//después con un foreach  se va poniendo cada caracter en la frase con un tiempo de retardo de 0.1 s

public class CNM2 : MonoBehaviour
{
    string frase = "¡Chiapas está dividido en siete distritos mineros, en los cuales se tiene la presencia de: Ámbar y Cuarzo";
    public Text texto;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
