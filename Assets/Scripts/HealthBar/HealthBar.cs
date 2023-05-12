// Barra de vida
// Comportamiento de la barra de vida

// Escrito por: Arantxa Garayzar Cristerna



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    //Slider
    public Slider slider;

    public void SetMaxHealth(int health){
        slider.maxValue = health;
        slider.value = health;
    }

    // Controlar el valor predefinido de la barra de vida
    public void SetHealth(int health){
        slider.value = health;
    }

    //Retorna el valor actual del slider
    public int GetHealth(){
        return (int)slider.value;
    }
}
