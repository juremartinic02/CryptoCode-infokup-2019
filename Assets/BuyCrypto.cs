using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCrypto : MonoBehaviour
{

    // skripta u kojoj dajemo funkciju kupovanja kriptovaluta

    public void BuyBitcoin()
    {
        if (Game.TotalCash >= Game.BitcoinValue)
        {
            Game.TotalCash = Game.TotalCash - Game.BitcoinValue;
            Game.BitcoinStock = Game.BitcoinStock + 1;
            Game.Save();
        }
    }

    public void BuyEthereum()
    {
        if (Game.TotalCash >= Game.EthereumValue)
        {
            Game.TotalCash = Game.TotalCash - Game.EthereumValue;
            Game.EthereumStock = Game.EthereumStock + 1;
            Game.Save();
        }
    }

    public void BuyDash()
    {
        if (Game.TotalCash >= Game.DashValue)
        {
            Game.TotalCash = Game.TotalCash - Game.DashValue;
            Game.DashStock = Game.DashStock + 1;
            Game.Save();
        }
    }

    public void BuyMonero()
    {
        if (Game.TotalCash >= Game.MoneroValue)
        {
            Game.TotalCash = Game.TotalCash - Game.MoneroValue;
            Game.MoneroStock = Game.MoneroStock + 1;
            Game.Save();
        }
    }
}