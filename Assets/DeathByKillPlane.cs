using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathByKillPlane : MonoBehaviour
{
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "KillPlane")
        {
            if (Hunter_Static.Score > Hunter_Static.HiScore)
            {
                Hunter_Static.HiScore = Hunter_Static.Score;
                Hunter_Static.Save();
                Game.TotalCash = Game.TotalCash + (Hunter_Static.Score / 10);
            }
            else
            {
                Game.TotalCash = Game.TotalCash + (Hunter_Static.Score / 10);
            }

            SceneManager.LoadScene("Pikachu_Menu");
        }
    }
}
