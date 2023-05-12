//por: Andrea Dominguez
//script para hacer aparecer un X número de ratones o murcielagos 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPolling : MonoBehaviour
{
    public GameObject prefab;
    public int amount = 10;//numero de enemigos  (prefabs)
    public int instantiateGap = 5; //cada 5 segundos
    // Start is called before the first frame update
    void Start()
    {
        InitializePool();//iniciar la repeticion de enemigos
        InvokeRepeating("GetEnemyFromPool", 1f, instantiateGap);
    }

    private void InitializePool()
    {
        for (int i = 0; i < amount; i++)
        {
            AddEnemyToPool();//agregar enemigos
        }
    }

    private void AddEnemyToPool()
    {
        GameObject enemy = Instantiate(prefab, this.transform.position, Quaternion.identity, this.transform);
        enemy.SetActive(false);// desactivar el enemigo cuando esta creado para tener un limite y que no se esten creando sin limite y saturar la memoria
    }

    private GameObject GetEnemyFromPool()
    {
        GameObject enemy = null;

        for(int i = 0; i < transform.childCount; i++)
        {
            if (!transform.GetChild(i).gameObject.activeSelf)
            {
                enemy = transform.GetChild(i).gameObject;
                break;
            }
        }

        //Del objeto gameobject se obtienen los enemigos ya que se van teniendo de un molde llamado prefab
        if(enemy == null)
        {
            AddEnemyToPool();
            enemy = transform.GetChild(transform.childCount - 1).gameObject;
        }

        enemy.transform.position = this.transform.position;
        enemy.SetActive(true);
        return enemy;
    }

}
