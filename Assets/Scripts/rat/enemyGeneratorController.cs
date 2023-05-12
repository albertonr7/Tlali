using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//test
//Por Andrea Dominguez
public class enemyGeneratorController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float generatorTimer = 1.75f;
    // Start is called before the first frame update
    void Start()
    {
        //invocar para que se repita el enemigo cada X tiempo
        InvokeRepeating("CreateEnemy", 0f, generatorTimer);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemy()
    {
        //Instanciar el prefab para crear enemigos
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
