using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuyMiner : MonoBehaviour
{

    // skripta pomoću koje dajemo funkciju kupovanja miner-a

    public void BuyMiner1()
    {
        var areAllTilesTaken = Game.Tile1 && 
                               Game.Tile2 && 
                               Game.Tile3 && 
                               Game.Tile4 && 
                               Game.Tile5 && 
                               Game.Tile6 && 
                               Game.Tile7 && 
                               Game.Tile8 && 
                               Game.Tile9 && 
                               Game.Tile10;

        if (!areAllTilesTaken && Game.TotalCash >= 50)
        {
            Game.TotalCash = Game.TotalCash - 50;

            Game.ShouldSpawnMiner = true;

            Game.SpawnMinerLevel = 1;

            SceneManager.LoadScene("Level1");

            Game.Save();
        }
    }

    public void BuyMiner2()
    {
        var areAllTilesTaken = Game.Tile1 &&
                               Game.Tile2 &&
                               Game.Tile3 &&
                               Game.Tile4 &&
                               Game.Tile5 &&
                               Game.Tile6 &&
                               Game.Tile7 &&
                               Game.Tile8 &&
                               Game.Tile9 &&
                               Game.Tile10;

        if (!areAllTilesTaken && Game.TotalCash >= 100)
        {
            Game.TotalCash = Game.TotalCash - 100;

            Game.ShouldSpawnMiner = true;

            Game.SpawnMinerLevel = 2;

            SceneManager.LoadScene("Level1");

            Game.Save();
        }
    }

    public void BuyMiner3()
    {
        var areAllTilesTaken = Game.Tile1 &&
                               Game.Tile2 &&
                               Game.Tile3 &&
                               Game.Tile4 &&
                               Game.Tile5 &&
                               Game.Tile6 &&
                               Game.Tile7 &&
                               Game.Tile8 &&
                               Game.Tile9 &&
                               Game.Tile10;

        if (!areAllTilesTaken && Game.TotalCash >= 250)
        {
            Game.TotalCash = Game.TotalCash - 250;

            Game.ShouldSpawnMiner = true;

            Game.SpawnMinerLevel = 3;

            SceneManager.LoadScene("Level1");

            Game.Save();
        }
    }

    public void BuyMiner4()
    {
        var areAllTilesTaken = Game.Tile1 &&
                               Game.Tile2 &&
                               Game.Tile3 &&
                               Game.Tile4 &&
                               Game.Tile5 &&
                               Game.Tile6 &&
                               Game.Tile7 &&
                               Game.Tile8 &&
                               Game.Tile9 &&
                               Game.Tile10;

        if (!areAllTilesTaken && Game.TotalCash >= 500)
        {
            Game.TotalCash = Game.TotalCash - 500;

            Game.ShouldSpawnMiner = true;

            Game.SpawnMinerLevel = 4;

            SceneManager.LoadScene("Level1");

            Game.Save();
        }
    }

    public void BuyMiner5()
    {
        var areAllTilesTaken = Game.Tile1 &&
                               Game.Tile2 &&
                               Game.Tile3 &&
                               Game.Tile4 &&
                               Game.Tile5 &&
                               Game.Tile6 &&
                               Game.Tile7 &&
                               Game.Tile8 &&
                               Game.Tile9 &&
                               Game.Tile10;

        if (!areAllTilesTaken && Game.TotalCash >= 1000)
        {
            Game.TotalCash = Game.TotalCash - 1000;

            Game.ShouldSpawnMiner = true;

            Game.SpawnMinerLevel = 5;

            SceneManager.LoadScene("Level1");

            Game.Save();
        }
    }

    public void SellMiner()
    {
        Game.ShouldSellMiner = true;
        SceneManager.LoadScene("Level1");
    }
}
