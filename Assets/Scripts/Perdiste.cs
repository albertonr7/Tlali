using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Por: Arantxa Garayzar Cristerna. lineas de codigo donde hay botones que te regresa a la escena
// menú (Boton "Salir") o al inicio del escenario (boton "Reintentar").

// Editado por Abraham Mendoza Rodriguez. Linea de codigo (23) hace que el contador del puntaje 
// inicialice desde 0 al reintentar (Boton "reintentar") la partida.

public class Perdiste : MonoBehaviour
{
    // Start is called before the first frame update
    public void Salir()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    public void Reintentar()
    {
        SceneManager.LoadScene("Escenario");
        GameController.Score = 0; //Inicializa en 0 el contador
    }
}
