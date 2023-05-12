using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarScore : MonoBehaviour
{
    public int Puntaje = 10;
    // Start is called before the first frame update
    void OnDestroy(){
        GameController.Score += Puntaje;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
