/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Por: Andrea Domínguez
public class controlRat : MonoBehaviour
{
    public float speed; //método publico para modificar la velocidad
    public float distance;//método publico para modificar la distancia

    private bool movingRight = true;

    public Transform groundDetection;

    // Healthbar: Escrito por Arantxa Garayzar Cristerna
    public HealthBar healthBar; // Objeto de tipo HealthBar para modificar los puntos de vida al pisar al ratón
    public int currentHealth;

    //Por Andrea
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //Movimiento a la derecha

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);//detectar collider, 
        if(groundInfo.collider == false)//si no hubo una colision con algun otro objeto, se hace el cambio de direccion
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true; 
            }
        }
    }

    // Detectando la colisión contra el collaider del jugador @ANR.
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            float yOffset = 0.4f;
            if (transform.position.y + yOffset < col.transform.position.y)
            {

                // Agrega un punto de vida al jugador @AGC
                currentHealth = healthBar.GetHealth();
                healthBar.SetHealth(currentHealth + 3);
                Debug.Log("VIDA: " + healthBar.GetHealth());
                Debug.Log("Sube vida");

                // Llamada al metodo publico del jugador para saltar.
                col.SendMessage("EnemyJump");
                Destroy(gameObject);
            }
        }
    }
}
*/