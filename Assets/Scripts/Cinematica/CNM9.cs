using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CNM9 : MonoBehaviour
{
    string frase = "¡Presta atención! en el camino puedes encontrar elementos que no son parte de Chiapas, si recoges alguno  te restará puntos";
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
