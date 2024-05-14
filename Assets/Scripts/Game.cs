using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public static class Game
{

    // statička klasa u koju spremamo određene vrijednosti i kasnije iz ove klase njima pristupamo u drugim skriptama

    #region Var koje spremamo

    public static string Username;
    public static string Email;
    public static string Password;

    public static List<int> BitcoinValueHistory = new List<int> { 500 };
    public static List<int> EthereumValueHistory = new List<int> { 300 };
    public static List<int> DashValueHistory = new List<int> { 100 };
    public static List<int> MoneroValueHistory = new List<int> { 250 };

    // dio koji se odnosi na općenite vrijednosti kriptovaluta
    public static int BitcoinValue = 500;
    public static int EthereumValue = 300;
    public static int DashValue = 100;
    public static int MoneroValue = 250;

    public static int BitcoinStock = 0;
    public static int EthereumStock = 0;
    public static int DashStock = 0;
    public static int MoneroStock = 0;

    public static DateTime LastBitcoinChange = DateTime.Now;
    public static DateTime LastEthereumChange = DateTime.Now;
    public static DateTime LastDashChange = DateTime.Now;
    public static DateTime LastMoneroChange = DateTime.Now;

    //je li zavrsna nagrada kupljena?

    public static bool IsEndPrizeBought;

    // dio koji se odnosi općenito za miner-e

    public static bool Tile1;
    public static bool Tile2;
    public static bool Tile3;
    public static bool Tile4;
    public static bool Tile5;
    public static bool Tile6;
    public static bool Tile7;
    public static bool Tile8;
    public static bool Tile9;
    public static bool Tile10;

    public static int Miner1 = 1;
    public static int Miner2 = 1;
    public static int Miner3 = 1;
    public static int Miner4 = 1;
    public static int Miner5 = 1;
    public static int Miner6 = 1;
    public static int Miner7 = 1;
    public static int Miner8 = 1;
    public static int Miner9 = 1;
    public static int Miner10 = 1;

    public static DateTime LastMinerAdvance = DateTime.Now;

    // dio gdje novac spremamo
    public static int TotalCash = 1000;

    #endregion

    // dio za SAVE

    // resetiranje igrice
    public static void ResetToDefaults()
    {
        BitcoinValueHistory = new List<int> { 500 };
        EthereumValueHistory = new List<int> { 300 };
        DashValueHistory = new List<int> { 100 };
        MoneroValueHistory = new List<int> { 250 };

        BitcoinValue = 500;
        EthereumValue = 300;
        DashValue = 100;
        MoneroValue = 250;

        BitcoinStock = 0;
        EthereumStock = 0;
        DashStock = 0;
        MoneroStock = 0;

        LastBitcoinChange = DateTime.Now;
        LastEthereumChange = DateTime.Now;
        LastDashChange = DateTime.Now;
        LastMoneroChange = DateTime.Now;

        IsEndPrizeBought = false;


        Tile1 = false;
        Tile2 = false;
        Tile3 = false;
        Tile4 = false;
        Tile5 = false;
        Tile6 = false;
        Tile7 = false;
        Tile8 = false;
        Tile9 = false;
        Tile10 = false;

        Miner1 = 1;
        Miner2 = 1;
        Miner3 = 1;
        Miner4 = 1;
        Miner5 = 1;
        Miner6 = 1;
        Miner7 = 1;
        Miner8 = 1;
        Miner9 = 1;
        Miner10 = 1;

        LastMinerAdvance = DateTime.Now;

        TotalCash = 10000;
    }

    // save-anje podatak korisničkog računa

    public static void Save()
    {
        var dto = new GameDto
        {
            Username = Game.Username,
            Email = Game.Email,
            Password = Game.Password,

            BitcoinValueHistory = Game.BitcoinValueHistory,
            EthereumValueHistory = Game.EthereumValueHistory,
            DashValueHistory = Game.DashValueHistory,
            MoneroValueHistory = Game.MoneroValueHistory,

            BitcoinValue = Game.BitcoinValue,
            EthereumValue = Game.EthereumValue,
            DashValue = Game.DashValue,
            MoneroValue = Game.MoneroValue,

            BitcoinStock = Game.BitcoinStock,
            EthereumStock = Game.EthereumStock,
            DashStock = Game.DashStock,
            MoneroStock = Game.MoneroStock,

            LastBitcoinChange = Game.LastBitcoinChange,
            LastEthereumChange = Game.LastEthereumChange,
            LastDashChange = Game.LastDashChange,
            LastMoneroChange = Game.LastMoneroChange,

            IsEndPrizeBought = Game.IsEndPrizeBought,

            Tile1 = Game.Tile1,
            Tile2 = Game.Tile2,
            Tile3 = Game.Tile3,
            Tile4 = Game.Tile4,
            Tile5 = Game.Tile5,
            Tile6 = Game.Tile6,
            Tile7 = Game.Tile7,
            Tile8 = Game.Tile8,
            Tile9 = Game.Tile9,
            Tile10 = Game.Tile10,

            Miner1 = Game.Miner1,
            Miner2 = Game.Miner2,
            Miner3 = Game.Miner3,
            Miner4 = Game.Miner4,
            Miner5 = Game.Miner5,
            Miner6 = Game.Miner6,
            Miner7 = Game.Miner7,
            Miner8 = Game.Miner8,
            Miner9 = Game.Miner9,
            Miner10 = Game.Miner10,

            LastMinerAdvance = Game.LastMinerAdvance,

            TotalCash = Game.TotalCash
        };

        var json = JsonConvert.SerializeObject(dto);

        var fileName = dto.Username + ".cry";

        var path = Path.Combine(Application.dataPath, fileName);

        File.WriteAllText(path, json);
    }

    // dio za LOAD

    public static bool Load()
    {
        var fileName = Game.Username + ".cry";

        var path = Path.Combine(Application.dataPath, fileName);

        if (!File.Exists(path))
        {
            return false;
        }

        var json = File.ReadAllText(path);

        var dto = JsonConvert.DeserializeObject<GameDto>(json);

        if (Game.Password != dto.Password)
        {
            return false;
        }

        Username = dto.Username;
        Email = dto.Email;
        Password = dto.Password;

        BitcoinValueHistory = dto.BitcoinValueHistory;
        EthereumValueHistory = dto.EthereumValueHistory;
        DashValueHistory = dto.DashValueHistory;
        MoneroValueHistory = dto.MoneroValueHistory;

        BitcoinValue = dto.BitcoinValue;
        EthereumValue = dto.EthereumValue;
        DashValue = dto.DashValue;
        MoneroValue = dto.MoneroValue;

        BitcoinStock = dto.BitcoinStock;
        EthereumStock = dto.EthereumStock;
        DashStock = dto.DashStock;
        MoneroStock = dto.MoneroStock;

        LastBitcoinChange = dto.LastBitcoinChange;
        LastEthereumChange = dto.LastEthereumChange;
        LastDashChange = dto.LastDashChange;
        LastMoneroChange = dto.LastMoneroChange;


        IsEndPrizeBought = dto.IsEndPrizeBought;

        Tile1 = dto.Tile1;
        Tile2 = dto.Tile2;
        Tile3 = dto.Tile3;
        Tile4 = dto.Tile4;
        Tile5 = dto.Tile5;
        Tile6 = dto.Tile6;
        Tile7 = dto.Tile7;
        Tile8 = dto.Tile8;
        Tile9 = dto.Tile9;
        Tile10 = dto.Tile10;

        Miner1 = dto.Miner1;
        Miner2 = dto.Miner2;
        Miner3 = dto.Miner3;
        Miner4 = dto.Miner4;
        Miner5 = dto.Miner5;
        Miner6 = dto.Miner6;
        Miner7 = dto.Miner7;
        Miner8 = dto.Miner8;
        Miner9 = dto.Miner9;
        Miner10 = dto.Miner10;

        LastMinerAdvance = dto.LastMinerAdvance;

        return true;
    }

    // dio gdje spremamo vrijednosti kriptovaluta u graf
    public static List<int> GraphValues = new List<int> { };


    // dio koji se odnosi na "chest reward" scenu
    public static DateTime NextChestOpen;
    public static bool IsChestReady;

    public static void ResetChest()
    {
        NextChestOpen = DateTime.Now + TimeSpan.FromDays(1);
        IsChestReady = false;
    }

    // dio koji se odnosi samo na BITCOIN


    public static TimeSpan BitcoinChangeTime = TimeSpan.FromMinutes(0.05);

    public static void TryAdvanceBitcoin()
    {
        while (LastBitcoinChange + BitcoinChangeTime <= DateTime.Now)
        {
            Bitcoin();
            LastBitcoinChange += BitcoinChangeTime;
        }
    }

    public static void Bitcoin()
    {
        if (100 < Game.BitcoinValue && Game.BitcoinValue < 3000)
        {
            int n = UnityEngine.Random.Range(5, 16);
            Game.BitcoinValue = (int)((decimal)n / 10 * Game.BitcoinValue);
        }

        if (Game.BitcoinValue >= 3000)
        {
            int n = UnityEngine.Random.Range(2, 20);
            Game.BitcoinValue = (int)((decimal)n / 10 * Game.BitcoinValue);
        }

        if (Game.BitcoinValue <= 10)
        {
            int n = UnityEngine.Random.Range(5, 10);
            Game.BitcoinValue = Game.BitcoinValue + n;
        }

        if (Game.BitcoinValue > 10 && Game.BitcoinValue <= 100)
        {
            int n = UnityEngine.Random.Range(8, 20);
            Game.BitcoinValue = (int)((decimal)n / 10 * Game.BitcoinValue);
        }

        Game.BitcoinValueHistory.Add(BitcoinValue);

        while (Game.BitcoinValueHistory.Count > 20)
        {
            Game.BitcoinValueHistory.RemoveAt(0);
        }
    }

    // dio koji se samo odnosi na ETHEREUM

    public static TimeSpan EthereumChangeTime = TimeSpan.FromMinutes(2);

    public static void TryAdvanceEthereum()
    {
        while (LastEthereumChange + EthereumChangeTime <= DateTime.Now)
        {
            Ethereum();
            LastEthereumChange += EthereumChangeTime;
        }
    }

    public static void Ethereum()
    {
        if (50 < Game.EthereumValue && Game.EthereumValue < 500)
        {
            int n = UnityEngine.Random.Range(8, 13);
            Game.EthereumValue = (int)((decimal)n / 10 * Game.EthereumValue);
        }

        if (Game.EthereumValue >= 500)
        {
            int n = UnityEngine.Random.Range(8, 12);
            Game.EthereumValue = (int)((decimal)n / 10 * Game.EthereumValue);
        }

        if (Game.EthereumValue <= 10)
        {
            int n = UnityEngine.Random.Range(5, 10);
            Game.EthereumValue = Game.EthereumValue + n;
        }

        if (Game.EthereumValue > 10 && Game.EthereumValue <= 50)
        {
            int n = UnityEngine.Random.Range(9, 13);
            Game.EthereumValue = (int)((decimal)n / 10 * Game.EthereumValue);
        }

        Game.EthereumValueHistory.Add(EthereumValue);

        while (Game.EthereumValueHistory.Count > 20)
        {
            Game.EthereumValueHistory.RemoveAt(0);
        }
    }

    // dio koji se samo odnosi na DASH

    public static TimeSpan DashChangeTime = TimeSpan.FromMinutes(3);

    public static void TryAdvanceDash()
    {
        while (LastDashChange + DashChangeTime <= DateTime.Now)
        {
            Dash();
            LastDashChange += DashChangeTime;
        }

    }

    public static void Dash()
    {
        if (20 < Game.DashValue && Game.DashValue < 200)
        {
            int n = UnityEngine.Random.Range(9, 11);
            Game.DashValue = (int)((decimal)n / 10 * Game.DashValue);
        }

        if (Game.DashValue >= 200)
        {
            int n = UnityEngine.Random.Range(9, 11);
            Game.DashValue = (int)((decimal)n / 10 * Game.DashValue);
        }

        if (Game.DashValue <= 10)
        {
            int n = UnityEngine.Random.Range(5, 10);
            Game.DashValue = Game.DashValue + n;
        }

        if (Game.DashValue > 10 && Game.DashValue <= 20)
        {
            int n = UnityEngine.Random.Range(10, 12);
            Game.DashValue = (int)((decimal)n / 10 * Game.DashValue);
        }

        Game.DashValueHistory.Add(DashValue);

        while (Game.DashValueHistory.Count > 20)
        {
            Game.DashValueHistory.RemoveAt(0);
        }

    }

    // dio koji se samo odnosi na MONERO

    public static TimeSpan MoneroChangeTime = TimeSpan.FromMinutes(5);

    public static void TryAdvanceMonero()
    {
        while (LastMoneroChange + MoneroChangeTime <= DateTime.Now)
        {
            Monero();
            LastMoneroChange += MoneroChangeTime;
        }
    }

    public static void Monero()
    {
        if (50 < Game.MoneroValue && Game.MoneroValue < 500)
        {
            int n = UnityEngine.Random.Range(8, 11);
            Game.MoneroValue = (int)((decimal)n / 10 * Game.MoneroValue);
        }

        if (Game.MoneroValue >= 500)
        {
            int n = UnityEngine.Random.Range(7, 11);
            Game.MoneroValue = (int)((decimal)n / 10 * Game.MoneroValue);
        }

        if (Game.MoneroValue <= 10)
        {
            int n = UnityEngine.Random.Range(5, 10);
            Game.MoneroValue = Game.MoneroValue + n;
        }

        if (Game.MoneroValue > 10 && Game.MoneroValue <= 50)
        {
            int n = UnityEngine.Random.Range(9, 11);
            Game.MoneroValue = (int)((decimal)n / 10 * Game.MoneroValue);
        }

        Game.MoneroValueHistory.Add(MoneroValue);

        while (Game.MoneroValueHistory.Count > 20)
        {
            Game.DashValueHistory.RemoveAt(0);
        }

    }


    public static TimeSpan MinerAdvanceTime = TimeSpan.FromSeconds(10);

    public static bool ShouldSpawnMiner;
    public static bool ShouldSellMiner;

    public static int SpawnMinerLevel;

    // dio za dobivanje novca od miner-a

    private static void GetCashForMinerLevel(int level)
    {
        if (level == 1)
        {
            Game.TotalCash += 1;
        }
        if (level == 2)
        {
            Game.TotalCash += 3;
        }
        if (level == 3)
        {
            Game.TotalCash += 8;
        }
        if (level == 4)
        {
            Game.TotalCash += 20;
        }
        if (level == 5)
        {
            Game.TotalCash += 50;
        }
    }

    public static void TryAdvanceMiners()
    {
        while (LastMinerAdvance + MinerAdvanceTime <= DateTime.Now)
        {
            LastMinerAdvance = LastMinerAdvance + MinerAdvanceTime;

            if (Tile1)
            {
                GetCashForMinerLevel(Miner1);
            }
            if (Tile2)
            {
                GetCashForMinerLevel(Miner2);
            }
            if (Tile3)
            {
                GetCashForMinerLevel(Miner3);
            }
            if (Tile4)
            {
                GetCashForMinerLevel(Miner4);
            }
            if (Tile5)
            {
                GetCashForMinerLevel(Miner5);
            }
            if (Tile6)
            {
                GetCashForMinerLevel(Miner6);
            }
            if (Tile7)
            {
                GetCashForMinerLevel(Miner7);
            }
            if (Tile8)
            {
                GetCashForMinerLevel(Miner8);
            }
            if (Tile9)
            {
                GetCashForMinerLevel(Miner9);
            }
            if (Tile10)
            {
                GetCashForMinerLevel(Miner10);
            }
        }
    }

    // dio koji nam služi za postavljanje i micanje miner-a

    public static void PlaceMineOnTile(int tileNumber)
    {
        if (tileNumber == 1)
        {
            Game.Tile1 = true;
            Game.Miner1 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 2)
        {
            Game.Tile2 = true;
            Game.Miner2 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 3)
        {
            Game.Tile3 = true;
            Game.Miner3 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 4)
        {
            Game.Tile4 = true;
            Game.Miner4 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 5)
        {
            Game.Tile5 = true;
            Game.Miner5 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 6)
        {
            Game.Tile6 = true;
            Game.Miner6 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 7)
        {
            Game.Tile7 = true;
            Game.Miner7 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 8)
        {
            Game.Tile8 = true;
            Game.Miner8 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 9)
        {
            Game.Tile9 = true;
            Game.Miner9 = Game.SpawnMinerLevel;
        }

        if (tileNumber == 10)
        {
            Game.Tile10 = true;
            Game.Miner10 = Game.SpawnMinerLevel;
        }
    }

    public static void RemoveMineFromTile(int tileNumber)
    {
        if (tileNumber == 1)
        {
            Game.Tile1 = false;
            Game.GetCashForMinerLevel(Game.Miner1);
            Game.ReturnMoneyForMinerLevel(Game.Miner1);
        }

        if (tileNumber == 2)
        {
            Game.Tile2 = false;
            Game.GetCashForMinerLevel(Game.Miner2);
            Game.ReturnMoneyForMinerLevel(Game.Miner2);
        }

        if (tileNumber == 3)
        {
            Game.Tile3 = false;
            Game.GetCashForMinerLevel(Game.Miner3);
            Game.ReturnMoneyForMinerLevel(Game.Miner3);
        }

        if (tileNumber == 4)
        {
            Game.Tile4 = false;
            Game.GetCashForMinerLevel(Game.Miner4);
            Game.ReturnMoneyForMinerLevel(Game.Miner4);
        }

        if (tileNumber == 5)
        {
            Game.Tile5 = false;
            Game.GetCashForMinerLevel(Game.Miner5);
            Game.ReturnMoneyForMinerLevel(Game.Miner5);
        }

        if (tileNumber == 6)
        {
            Game.Tile6 = false;
            Game.GetCashForMinerLevel(Game.Miner6);
            Game.ReturnMoneyForMinerLevel(Game.Miner6);
        }

        if (tileNumber == 7)
        {
            Game.Tile7 = false;
            Game.GetCashForMinerLevel(Game.Miner7);
            Game.ReturnMoneyForMinerLevel(Game.Miner7);
        }

        if (tileNumber == 8)
        {
            Game.Tile8 = false;
            Game.GetCashForMinerLevel(Game.Miner8);
            Game.ReturnMoneyForMinerLevel(Game.Miner8);
        }

        if (tileNumber == 9)
        {
            Game.Tile9 = false;
            Game.GetCashForMinerLevel(Game.Miner9);
            Game.ReturnMoneyForMinerLevel(Game.Miner9);
        }

        if (tileNumber == 10)
        {
            Game.Tile10 = false;
            Game.GetCashForMinerLevel(Game.Miner10);
            Game.ReturnMoneyForMinerLevel(Game.Miner10);
        }
    }

    public static void ReturnMoneyForMinerLevel(int level)
    {
        if (level == 1)
        {
            Game.TotalCash += 25;
        }
        if (level == 2)
        {
            Game.TotalCash += 50;
        }
        if (level == 3)
        {
            Game.TotalCash += 125;
        }
        if (level == 4)
        {
            Game.TotalCash += 250;
        }
        if (level == 5)
        {
            Game.TotalCash += 500;
        }
    }
}

// vrijednosti koje poprimaju property vrijednosti

public class GameDto
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public List<int> BitcoinValueHistory { get; set; }
    public List<int> EthereumValueHistory { get; set; }
    public List<int> DashValueHistory { get; set; }
    public List<int> MoneroValueHistory { get; set; }

    public int BitcoinValue { get; set; }
    public int EthereumValue { get; set; }
    public int DashValue { get; set; }
    public int MoneroValue { get; set; }

    public int BitcoinStock { get; set; }
    public int EthereumStock { get; set; }
    public int DashStock { get; set; }
    public int MoneroStock { get; set; }

    public DateTime LastBitcoinChange { get; set; }
    public DateTime LastEthereumChange { get; set; }
    public DateTime LastDashChange { get; set; }
    public DateTime LastMoneroChange { get; set; }

    public bool IsEndPrizeBought { get; set; }

    public bool Tile1 { get; set; }
    public bool Tile2 { get; set; }
    public bool Tile3 { get; set; }
    public bool Tile4 { get; set; }
    public bool Tile5 { get; set; }
    public bool Tile6 { get; set; }
    public bool Tile7 { get; set; }
    public bool Tile8 { get; set; }
    public bool Tile9 { get; set; }
    public bool Tile10 { get; set; }

    public int Miner1 { get; set; }
    public int Miner2 { get; set; }
    public int Miner3 { get; set; }
    public int Miner4 { get; set; }
    public int Miner5 { get; set; }
    public int Miner6 { get; set; }
    public int Miner7 { get; set; }
    public int Miner8 { get; set; }
    public int Miner9 { get; set; }
    public int Miner10 { get; set; }

    public DateTime LastMinerAdvance { get; set; }

    public int TotalCash { get; set; }
}