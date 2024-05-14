using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EthereumValueScript : MonoBehaviour
{

    // skripta koja mijenja vrijednost Ethereum-a svako dvije minute

    public GameObject EthereumValueDisplay;

    public Text text;

    public void CryptoValueChanger()
    {
        Game.TryAdvanceEthereum();
    }

    void Start()
    {
        text = EthereumValueDisplay.GetComponent<Text>();

        text.text = "Price: " + Game.EthereumValue + " $";

        InvokeRepeating("Ethereum", 120f, 120f);
    }

    private void Update()
    {
        CryptoValueChanger();

        text.text = "Price: " + Game.EthereumValue + " $";

    }
}
