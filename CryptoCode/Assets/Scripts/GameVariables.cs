using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameVariables
{
    public static int Kune;

    public static void LoadSaveData()
    {
        Kune = PlayerPrefs.GetInt("Kune", 0);
    }

    public static void SaveData()
    {
        PlayerPrefs.SetInt("Kune", Kune);

        PlayerPrefs.Save();
    }
}
