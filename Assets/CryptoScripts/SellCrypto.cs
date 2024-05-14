using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCrypto : MonoBehaviour
{

    // skripta pomoću koje prodajemo kriptovalute

    public void SellBitcoin()
    {
        if (Game.BitcoinStock >= 1)
        {
            Game.BitcoinStock = Game.BitcoinStock - 1;
            Game.TotalCash = Game.TotalCash + Game.BitcoinValue;
            Game.Save();
        }
    }

    public void SellEthereum()
    {
        Game.EthereumStock = Game.EthereumStock - 1;
        Game.TotalCash = Game.TotalCash + Game.EthereumValue;
        Game.Save();
    }

    public void SellDash()
    {
        Game.DashStock = Game.DashStock - 1;
        Game.TotalCash = Game.TotalCash + Game.DashValue;
        Game.Save();
    }

    public void SellMonero()
    {
        Game.MoneroStock = Game.MoneroStock - 1;
        Game.TotalCash = Game.TotalCash + Game.MoneroValue;
        Game.Save();
    }

}
