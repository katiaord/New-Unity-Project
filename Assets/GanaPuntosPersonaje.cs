using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GanaPuntosPersonaje : MonoBehaviour
{
    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Puntos Jugador 1:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
