using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPrizeScript : MonoBehaviour
{

    // skripta koja omogućuje pristup glavnoj nagradi ako igrač ima dovoljno "in game" novca



    public void EndButton()
    {
        if (Game.IsEndPrizeBought)
        {
            SceneManager.LoadScene("EndGameReward");

            return;
        }

        if (Game.TotalCash >= 50000)
        {
            Game.IsEndPrizeBought = true;
            Game.TotalCash = Game.TotalCash - 50000;

            SceneManager.LoadScene("EndGameReward");

            return;
        }
    }
}
