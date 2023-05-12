// Player Health - Vida del personaje
// Escrito por: Arantxa Garayzar Cristerna
// Con este código se ontrola la vida del personaje. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    // El número máximo de puntos de vida
    public int maxHealth = 3;

    // Puntos de vida actuales
    public int currentHealth;

    // Instancia del objeto HealthBar creado en otro Script. 
    public HealthBar healthBar;
    // Esta función establece los valores iniciales de todos los elementos del script.
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Detectar cuando se presente una colisión entre el personaje y los enemigos.
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Raton" || other.gameObject.tag=="Murcielago"){
            float yOffset = 0.4f;
            if(other.transform.position.y + yOffset < transform.position.y){
            } else {
                TakeDamage(1);
            }
        }
        // Si la vida ya es menor que 1 el usuario pierde
        if(healthBar.GetHealth() < 1){
            SceneManager.LoadScene("Fail");
        }

    }
    // Una función que recibe la cantidad de puntos de vida que perder. 
    void TakeDamage(int damage){
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
