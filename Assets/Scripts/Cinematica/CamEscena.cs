using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Por: Rebeca De la Luz Elizalde
public class CamEscena : MonoBehaviour
{

    // Botón de Volver por Andrea Dominguez
    
    public void Regresar()
    { // Regresar al menu principal.
        SceneManager.LoadScene("Menu");
    }

    
    public string scene;

	private void OnMouseDown()
	{
		SceneManager.LoadScene(scene);
	}
}
