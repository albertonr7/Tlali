using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public static int Score = 0;
    public string ScoreString = "Puntaje";

    public Text TextScore;
    public static GameController controller;
    // Start is called before the first frame update
    void Awake(){
        controller = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = ScoreString + Score.ToString ();
            
        }
        
    }
}
