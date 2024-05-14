using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class SaveChestTime : MonoBehaviour
{

    // skripta koja služi za pohranjivanje vremena u jedinstvenom formatu

    void Start()
    {

    }


    void Update()
    {
        Game.NextChestOpen = DateTime.Now + TimeSpan.FromDays(1);
        
        var nextChestOpenSterialazed = Game.NextChestOpen.ToString("O");

        var a = DateTime.ParseExact(nextChestOpenSterialazed, "O", CultureInfo.InvariantCulture);
    }
}
