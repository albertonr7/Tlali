using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CNM6 : MonoBehaviour
{
    string frase = "¡Ten cuidado con los enemigos! El murciélago frugívoro y el ratón chiapaneco por cada vez que te ataquen te restaran vida, adicionalmente tienes que esquivar al murciélago porque te puede tirar de una platoforma y caerás al vacío";
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
