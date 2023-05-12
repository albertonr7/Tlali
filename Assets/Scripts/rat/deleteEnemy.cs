using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Por andrea Dominguez 
public class deleteEnemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)//para detectar el objeto collider y salga de la escena se elimine
    {
        
        if (col.gameObject.tag == "Murcielago")
        {
            col.gameObject.SetActive(false);
        }
    }
}
