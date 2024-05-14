using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BitcoinValueScript : MonoBehaviour
{

    // skripta koja mijenja vrijednost Bitcoin-a svako dvije minute

    public GameObject BitcoinValueDisplay;

    public Text text;

    public void CryptoValueChanger()
    {
        Game.TryAdvanceBitcoin();
    }

    void Start()
    {
        text = BitcoinValueDisplay.GetComponent<Text>();

        text.text = "Price: " + Game.BitcoinValue + " $";

        
    }

    void Update()
    {

        CryptoValueChanger();

        text.text = "Price: " + Game.BitcoinValue + " $";
    }
}
