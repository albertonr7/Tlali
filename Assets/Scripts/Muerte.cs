using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Por: Alberto Nieto Rocha, código para que cuando el ratón o el personaje 
// se salgan de la escena y toquen el collider correspondiente se desactiven.

// Editado por: Abraham Mendoza Rodriguez. linea de codigo (23) donde hace que el jugador 
// muera y aparesca la escena donde haga que reinicie el juego o salga//
public class Muerte : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        // En caso del ratón se elimina
        if (col.gameObject.tag == "Raton"){
            col.gameObject.SetActive(false);
    	}
        // En caso del jugador se desactiva y se carga la pantalla de derrota.
        if(col.gameObject.tag == "Player"){
            col.gameObject.SetActive(false);
            SceneManager.LoadScene ("Fail"); //Cuando el jugador colisiona carga la escena (fail "oh no, intentalo de nuevo")// 
        }
    }
}
