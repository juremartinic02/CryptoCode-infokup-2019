using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScoreRenderer : MonoBehaviour
{

    // skripta za prikazivanje najvećeg postignutog rezultata koji smo postigli u mini igri

    private Text scoreText;

    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "HiScore: " + Hunter_Static.HiScore;
    }
}
