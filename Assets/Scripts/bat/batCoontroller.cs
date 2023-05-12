using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Por Andrea Dominguez
//Para tener el control del murciélago
public class batCoontroller : MonoBehaviour
{

    public float maxSpeed = 1f; //ayuda a tener una velocidad constante
    public float speed = 1f;
    private Rigidbody2D rb2d;//

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();//obtener el componente rigidbody 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.AddForce(Vector2.right * speed);
        //velocidad limite
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        //ccambiar la direccion del movimiento
        if (rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f)
        {
            speed = -speed;
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }

        // Cambio de dirección del sprite
        if (speed > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (speed < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }



    // Detectando la colisión contra el jugador. @ANR
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            float yOffset = 1f;
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