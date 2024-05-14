using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EthereumStockNumberScript : MonoBehaviour
{

    // skripta koja govori igraču koliko Ethereum-a ima

    public GameObject EthereumStockNumberDisplay;

    public Text text;

    void Start()
    {
        text = EthereumStockNumberDisplay.GetComponent<Text>();
    }


    void Update()
    {
        text.text = "Amount of ethereum owned: " + Game.EthereumStock;
    }
}
