using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Hunter_Static
{

    // spremnje i učitavnje scene nakon što izađemo iz igrice


    public static int Score;
    public static int HiScore;

    public static void Save()
        {
            PlayerPrefs.SetInt("HiScore", Hunter_Static.HiScore);
            PlayerPrefs.Save();
        }

    public static void Load()
    {
        HiScore = PlayerPrefs.GetInt("HiScore");
    }
}
