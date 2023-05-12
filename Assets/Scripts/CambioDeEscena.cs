using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Por Rebeca De la Luz Elizalde y Abraham Mendoza Rodriguez. Codigo para hacer el cambio 
// de escena final cuando el jugar termine de jugar en el escenario y aparezca el puntaje correspondiente. 

public class CambioDeEscena : MonoBehaviour
{
    public GameObject EffectDie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    // Colisión con Objeto (letrero) carga la escena correspondiente comparando el score (puntaje)
    void OnTriggerEnter2D(Collider2D Aventurero){
            if (Aventurero.tag == "Player"){    //Jugador
                Debug.Log ("Hola");
                if(GameController.Score <= 100 ){   // Puntaje menor a 100 puntos 
                    SceneManager.LoadScene ("GameOver"); // Carga escena de 0 puntaje 
                }
                if(GameController.Score > 100 && GameController.Score <= 120){  //Puntaje hasta 120 puntos
                    SceneManager.LoadScene ("GameOver1");   // Carga escena de 1 estrella
                }
                if(GameController.Score > 120 && GameController.Score <= 160){  // Puntaje hasta 160 puntos
                    SceneManager.LoadScene ("GameOver2");   // Carga escena de 2 estrellas
                }
                if(GameController.Score > 160){  //Puntaje más de 160 puntos
                    SceneManager.LoadScene ("GameOver3");   // Carga escena de 3 estrellas, máximo puntaje 
                }

                
            }
    
        }
}
