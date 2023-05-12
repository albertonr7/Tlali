using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    // En esta variable configuraremos la velocidad a la que se moverá el objeto
    public Rigidbody2D rBD;
    public float speed = 1f, jumpForce = 50;
    private SpriteRenderer mySpriteRenderer;
    public float Velocidad = 5.0F;
    private bool derecha = false;
    private bool izquierda = false;
    private bool saltar = false;
    private Animator _animator;
    public float radio = 0.2f;
    public LayerMask layerSuelo;
    public Transform pie;
    public bool estaEnSuelo;
    
    // Start is called before the first frame update

    void Awake()
    {  
        mySpriteRenderer = GetComponent<SpriteRenderer>();
       _animator = GetComponent<Animator>();
    }
    void Start()
    {
        rBD = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        DecSuelo();
        if(derecha)
        {
            // Movemos el objeto hacia la derecha
            if(mySpriteRenderer != null)
            {
                 // flip the sprite
                 mySpriteRenderer.flipX = false;
            }
            this.transform.Translate(Vector3.right * Time.deltaTime * Velocidad);
        }
 
        if (izquierda)
        {
            // Movemos el objeto hacia la izquierda
            if(mySpriteRenderer != null)
            {
                 // flip the sprite
                 mySpriteRenderer.flipX = true;
            }
            this.transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
        }
        if (saltar){
            if(estaEnSuelo == true){
                Salto();
            }
            
        }
 
        
    }

    /*Funciones*/
    public void MoverDerecha()
    {
        
        _animator.SetBool("Parado",true);
        derecha = true;
    }
 
    public void MoverIzqda()
    {
        _animator.SetBool("Parado",true);
        izquierda = true;

    }
 
 
    public void Detener()
    {
        _animator.SetBool("Parado",false);
        derecha = false;
        izquierda = false;
    }

    public void DecSuelo(){
        estaEnSuelo = Physics2D.OverlapCircle(pie.position,radio,layerSuelo);
    }

    public void Salto(){
        if (estaEnSuelo == false)
        {
            return;
        }
        rBD.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        _animator.SetBool("Saltar",true);
        
    }

    public void EnemyJump(){
        saltar = true;
    }
 
}
