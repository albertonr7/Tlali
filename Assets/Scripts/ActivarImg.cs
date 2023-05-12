using System.Collections;
using UnityEngine;

public class ActivarImg : MonoBehaviour
{
    public GameObject objeto;
    public int tiempo;
    // Start is called before the first frame update
    void Start()
    {
        objeto.gameObject.SetActive(false);
        StartCoroutine("Esperar");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Esperar(){
        yield return new WaitForSeconds (tiempo);
        objeto.gameObject.SetActive(true);

    }
}
