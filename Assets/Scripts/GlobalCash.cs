using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{

    // skirpta kojom se ispisuje suma novca koju posjedujemo u igrici

    public GameObject CashDisplay;

    public Text cashText;



    void Start()
    {
        cashText = CashDisplay.GetComponent<Text>();
    }

    void Update()
    {
        cashText.text = "" + Game.TotalCash;

    }
}
