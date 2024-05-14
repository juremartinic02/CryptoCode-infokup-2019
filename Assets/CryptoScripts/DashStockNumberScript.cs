using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashStockNumberScript : MonoBehaviour
{
    
    // skripta kojom renderireamo koliko dash-a imamo

    public GameObject DashStockNumberDisplay;

    public Text text;

    void Start()
    {
        text = DashStockNumberDisplay.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Amount of dash owned: " + Game.DashStock;
    }
}
