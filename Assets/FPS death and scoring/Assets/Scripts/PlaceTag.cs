using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTag : MonoBehaviour
{

    // skripta koja provjerava ima li slobodnih prostora za postavit miner

    public int Number;
    public GameObject Level1MinerPrefab;
    public GameObject Level2MinerPrefab;
    public GameObject Level3MinerPrefab;
    public GameObject Level4MinerPrefab;
    public GameObject Level5MinerPrefab;

    private void Start()
    {
        if (Number == 1 && Game.Tile1)
        {
            PlaceMinerOfLevel(Game.Miner1);
        }

        if (Number == 2 && Game.Tile2)
        {
            PlaceMinerOfLevel(Game.Miner2);
        }

        if (Number == 3 && Game.Tile3)
        {
            PlaceMinerOfLevel(Game.Miner3);
        }

        if (Number == 4 && Game.Tile4)
        {
            PlaceMinerOfLevel(Game.Miner4);
        }

        if (Number == 5 && Game.Tile5)
        {
            PlaceMinerOfLevel(Game.Miner5);
        }

        if (Number == 6 && Game.Tile6)
        {
            PlaceMinerOfLevel(Game.Miner6);
        }

        if (Number == 7 && Game.Tile7)
        {
            PlaceMinerOfLevel(Game.Miner7);
        }

        if (Number == 8 && Game.Tile8)
        {
            PlaceMinerOfLevel(Game.Miner8);
        }

        if (Number == 9 && Game.Tile9)
        {
            PlaceMinerOfLevel(Game.Miner9);
        }

        if (Number == 10 && Game.Tile10)
        {
            PlaceMinerOfLevel(Game.Miner10);
        }
    }

    private void PlaceMinerOfLevel(int level)
    {
        if (level == 1)
        {
            GameObject.Instantiate(Level1MinerPrefab, this.transform);
        }
        if (level == 2)
        {
            GameObject.Instantiate(Level2MinerPrefab, this.transform);
        }
        if (level == 3)
        {
            GameObject.Instantiate(Level3MinerPrefab, this.transform);
        }
        if (level == 4)
        {
            GameObject.Instantiate(Level4MinerPrefab, this.transform);
        }
        if (level == 5)
        {
            GameObject.Instantiate(Level5MinerPrefab, this.transform);
        }
    }
}
