using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CNM4: MonoBehaviour
{
    string frase = "Como parte de la flora de Lacandona puedes encontrar: Bromelias, Orquídeas, Cedros, Caoba, Helechos";
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
