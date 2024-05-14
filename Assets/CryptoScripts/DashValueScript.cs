using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashValueScript : MonoBehaviour
{

    // skripta koja mijenja vrijednost Dash-a svako dvije minute

    public GameObject DashValueDisplay;

    public Text text;

    public void CryptoValueChanger()
    {
        Game.TryAdvanceDash();
    }

    void Start()
    {
        text = DashValueDisplay.GetComponent<Text>();

        text.text = "Price: " + Game.DashValue + " $";     
    }

    private void Update()
    {
        CryptoValueChanger();

        text.text = "Price: " + Game.DashValue + " $";
    }


}
