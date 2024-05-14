using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneroStockNumberScript : MonoBehaviour
{

    // skripta koja omogućuje igraču da vidi koliko Monero-a ima

    public GameObject MoneroStockOwnedDisplay;

    public Text text;

    void Start()
    {
        text = MoneroStockOwnedDisplay.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Amount of monero owned: " + Game.MoneroStock;
    }
}
