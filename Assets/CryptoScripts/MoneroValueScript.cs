using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MoneroValueScript : MonoBehaviour
{

    // skripta koja mijenja vrijednost Monero-a svako dvije minute

    public GameObject MoneroValueDisplay;

    public Text text;

    public void CryptoValueChanger()
    {
        Game.TryAdvanceMonero();
    }

    void Start()
    {
        text = MoneroValueDisplay.GetComponent<Text>();

        text.text = "Price: " + Game.MoneroValue + " $";
    }

    private void Update()
    {
        CryptoValueChanger();

        text.text = "Price: " + Game.MoneroValue + " $";
    }


}
