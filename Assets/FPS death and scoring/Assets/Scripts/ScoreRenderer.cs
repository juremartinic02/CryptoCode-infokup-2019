using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRenderer : MonoBehaviour
{
    private Text scoreText;

    // skripta za prikazivanje rezultata na sceni

    void Start()
    {
        scoreText = this.GetComponent<Text>();
        Hunter_Static.Score = 0;

    }

    void Update()
    {
        scoreText.text = "Score: " + Hunter_Static.Score;
    }
}
