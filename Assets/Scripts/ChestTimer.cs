using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestTimer : MonoBehaviour
{

    // skripta kojom smo postavili brojač in game chest-u 
    // kada brojač dođe do 0h:0min:0sek onda se chest može otvoriti

    public Button button;
    public Text text;

    void Start()
    {
    }

    void Update()
    {
        button.interactable = Game.IsChestReady;

        if (!Game.IsChestReady)
        {
            var timeUntilChestOpen = Game.NextChestOpen - DateTime.Now;
            text.text = timeUntilChestOpen.Hours + ":" +
                        timeUntilChestOpen.Minutes + ":" +
                        timeUntilChestOpen.Seconds;

            if (Game.NextChestOpen < DateTime.Now)
            {
                Game.IsChestReady = true;
            }
        }
        else
        {
            text.text = "Ready!";
        }
    }

}