// Patrol
// Tiene como objetivo hacer al enemigo "ratón chiapaneco" seguir al jugador dentro del escenario.
// Fue realizado por Arantxa Garayzar Cristerna

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform player;

    private Rigidbody2D rb;

    private Vector2 movement;

    public float moveSpeed = 3f;

    public float scale;

    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
        scale = transform.localScale.x;
    }

    void Update(){
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if(angle>=0 && angle<=90){
            transform.localScale = new Vector2(scale, transform.localScale.y);
        }
        if(angle >= 90 && angle <= 180){
            transform.localScale = new Vector2(-scale, transform.localScale.y);
        }
        Debug.Log(direction);
        direction.Normalize();
        movement = direction;
    }

    void FixedUpdate(){
        moveEnemy(movement);
    }

    void moveEnemy(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
