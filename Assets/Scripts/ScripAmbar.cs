using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripAmbar : MonoBehaviour
{
    public GameObject EffectDie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D Aventurero){
        if(Aventurero.tag == "Player"){
            Debug.Log ("+10!!");
            if (EffectDie != null)
            {
                Instantiate (EffectDie, transform.position, transform.rotation);
            }
            Destroy (gameObject);
        }
    }
}