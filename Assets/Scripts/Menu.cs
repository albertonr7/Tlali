using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Realizado por: Alberto Nieto Rocha
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jugar(string nombreNivel){
        SceneManager.LoadScene (nombreNivel);
    }

    // Es llamada al pulsar la opcion de salir.
    public void salir(){
        Application.Quit();
    }
    
}
