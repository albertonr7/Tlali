// Script para Selector de niveles / Mapa de Niveles
// Laboratorio Tematico IV
// UAM Cuajimalpa
// Realizado por: Arantxa Garayzar Cristerna


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    // Funcion para agregar las funcionalidades al "menu" del mapa de niveles
    // o tambien selector de nivel. 

    // Botón de Volver
    // Para volver al menu principal hecho por Alberto.
    public void Regresar(){ // Regresar al menu principal.
        SceneManager.LoadScene("Menu");
    }

    // Botón de Chiapas
    // Al presionar te direcciona ala cinematica de chiapas.
    public void JugarChiapas() {
        SceneManager.LoadScene("CNM1");
    }
}
