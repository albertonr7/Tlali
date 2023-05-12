using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// @Alberto Nieto Rocha, esté script siver para hacer que las plataformas caigan y despues reaparescan.
public class PlataformaCae : MonoBehaviour
{

    public float retrasoCaida = 1f;
    public float retrasoAparicion = 3f;
    private Rigidbody2D rb2d;
    private PolygonCollider2D pc2d;
    private Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pc2d = GetComponent<PolygonCollider2D>();
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Al tocar el personaje la plataforma se cambia la física de la plataforma para que caiga.
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Player")){
            Invoke("Caida", retrasoCaida); 
            Invoke("Reaparecer", retrasoCaida + retrasoAparicion); 
        }
    }

    // Pierde gravedad y se vuelve transparente a otros objetos.
    void Caida(){
        rb2d.isKinematic = false;
        pc2d.isTrigger = true;
    }

    // Propiedades para que la plataforma no caiga, se ponga en su posició original,
    // pierda la velocidad y detecte otros objetos.
    void Reaparecer(){
        transform.position = posicionInicial;
        rb2d.isKinematic = true;
        rb2d.velocity = Vector3.zero;
        pc2d.isTrigger = false;
    }

}
