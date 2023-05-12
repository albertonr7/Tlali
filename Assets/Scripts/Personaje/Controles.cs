using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Versión 1 realizada por Rebeca.
// Esta versión es realizada por: @Alberto Nieto Rocha, script para controlar todos los movimientos e interacciones del personaje,
// con este se muestran las animaciones de movimiento y las interacciones que realiza con los enemigos.
public class Controles : MonoBehaviour
{
    // Velocidad maxima y velocidad del personaje.
    public float velocidadMaxima = 1.5f;
    public float velocidad = 125f;
    public bool suelo;
    public float fuerzaSalto = 7.5f;
    private bool salto;
    private bool dobleSalto;
    private bool movimiento;
    private SpriteRenderer sprite;
    private Rigidbody2D rb2d;
    private Animator anim;
    private float h = 0f;
    public Joystick mando;

    // Buscamos el componente dentro del personaje.
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Velocidad", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", suelo);
    }

    void FixedUpdate()
    {
        // Pequeña frixión para que el muñeco no se este moviendo.
        Vector3 fixedVelocity = rb2d.velocity;
        fixedVelocity.x *= 0.75f;

        if(suelo){
            rb2d.velocity = fixedVelocity;    
        }

        // Aplicacamos la velocidad horizontal con las teclas y les aplicamos el limite de velocidad.
        if(mando.Horizontal >= .2f){
            h = velocidadMaxima;
        }else if(mando.Horizontal <= - .2f){
            h = -velocidadMaxima;
        }else{
            h = 0;
        }

        // Mover al personaje en eje horizontal.
        rb2d.AddForce(Vector2.right * velocidad * h);

        float velocidadLimite = Mathf.Clamp(rb2d.velocity.x, -velocidadMaxima, velocidadMaxima);
        rb2d.velocity = new Vector2(velocidadLimite, rb2d.velocity.y);

        if(h > 1){
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if(h < -1){
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        // Salto
        if(salto){
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            salto = false;
        }
    }

    // Salto al aplastar al enemigo o al tocar un trampolin.
    public void EnemyJump(){
        salto = true;
    }

    // Retroceso del jugador al ser golpeado por un enemigo.
    // también se bloquea al jugador para que no pueda mover al personaje mientras es impulsado
    // y se cambia el color del sprite para dar la impresión de daño.
    public void ataqueEnemigo(float posicionEnemigo){
        salto = true;
        float lado = Mathf.Sign(posicionEnemigo - transform.position.x);
        rb2d.AddForce(Vector2.left * lado * fuerzaSalto, ForceMode2D.Impulse);
        movimiento = false;
        Invoke("activarMovimiento", 0.7f);
        sprite.color = Color.red;
    }

    // Se permite al usuario manejar al personaje de nuevo y se regresa el color normal del personaje.
    void activarMovimiento(){
        movimiento = true;
        sprite.color = Color.white;
    }

    // Este metodo es llamado para activar el salto en el personaje.
    public void saltoBoton(){
        // Salto extra, al caer permite saltar.
        if(salto){
            dobleSalto = true;
        }

        // Salto y salto doble.
        if(suelo){
            salto = true;
            dobleSalto = true;
        }else if(dobleSalto){
            salto = true;
            dobleSalto = false;
        }
    }

}
