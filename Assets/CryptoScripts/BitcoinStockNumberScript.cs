using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BitcoinStockNumberScript : MonoBehaviour
{

    // skripta kojom renderiramo koliko bitcoina imamo

    public GameObject BitcoinStockOwnedDisplay;

    public Text text;

    void Start()
    {
        text = BitcoinStockOwnedDisplay.GetComponent<Text>();
    }
    void Update()
    {
        text.text = "Amount of bitcoin owned: " + Game.BitcoinStock;
    }
}
