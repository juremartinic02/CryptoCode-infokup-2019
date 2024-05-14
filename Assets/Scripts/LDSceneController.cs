using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LDSceneController : MonoBehaviour
{

    // skripta koja prebacuje igrača na scenu koju je zaslužio (scena pobjede ili poraza)

    void Update()
    {
        var players = GameObject.FindGameObjectsWithTag("LD_Players");
        var enemies = GameObject.FindGameObjectsWithTag("LD_Enemies");

        Debug.Log(players.Length);
        Debug.Log(enemies.Length);

        if (players.Length <= 0)
        {
            SceneManager.LoadScene("Lose");
        }

        if (enemies.Length <= 0)
        {
            SceneManager.LoadScene(sceneName: "Win");
            Game.TotalCash = Game.TotalCash + 1;
        }
    }
}
