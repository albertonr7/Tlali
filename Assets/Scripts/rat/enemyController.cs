using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Para obtener acceso a elementos de UI (Slider). @AGC

//Por Andrea Dom. Lara
//para tener el control del enemigo
public class enemyController : MonoBehaviour
{

    public float maxSpeed = 1f; //para tener una velocidad constante
    public float speed = 1f;  //Para una velocidad constante 
    private Rigidbody2D rb2d; //Objeto de tipo rigidbody 
    

    // Healthbar: Escrito por Arantxa Garayzar Cristerna
    public HealthBar healthBar; // Objeto de tipo HealthBar para modificar los puntos de vida al pisar al ratón
    public int currentHealth ;
    // Fin healthbar

    void Start()
    {
        //Por Andrea Dom. 
        rb2d = GetComponent<Rigidbody2D>();//obtener el componente rigidbody
    }

    
    void FixedUpdate()
    {
        rb2d.AddForce(Vector2.right * speed);
        //Velocidad limite
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        //para cambiar la direccion del movimiento
        if (rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f)
        {
            speed = -speed;
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }

        // Cambio de dirección del sprite
        if (speed > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }else if (speed < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    // Detectando la colisión contra el collaider del jugador @ANR.
    // Llamada a la función de personaje para que salte y se ponga color rojo.
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            float yOffset = .5f;
            if (transform.position.y + yOffset < col.transform.position.y)
            {
                // Llamada al metodo publico del jugador para saltar.
                col.SendMessage("EnemyJump");
                Destroy(gameObject);
            }
            else
            {
                col.SendMessage("ataqueEnemigo", transform.position.x);
            }
        }
    }
}
