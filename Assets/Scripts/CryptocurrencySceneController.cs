using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CryptocurrencySceneController : MonoBehaviour
{

    // skripta kojom dajemo vrijednost grafu

    public void OpenBitcoin()
    {
        Game.GraphValues = Game.BitcoinValueHistory;
        SceneManager.LoadScene("BitcoinGraph");
    }

    public void OpenEthereum()
    {
        Game.GraphValues = Game.EthereumValueHistory;
        SceneManager.LoadScene("EthereumGraph");
    }

    public void OpenDash()
    {
        Game.GraphValues = Game.DashValueHistory;
        SceneManager.LoadScene("DashGraph");
    }

    public void OpenMonero()
    {
        Game.GraphValues = Game.MoneroValueHistory;
        SceneManager.LoadScene("MoneroGraph");
    }


}