using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour
{

    // skripta koja omogućuje igraču da pritiskom na "New game" resetira igru,  pritsikom na "Load game" nastavi igru gdje je stao, a pritiskom na "Quit game" izađe iz igre

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
        PlayerPrefs.DeleteAll();
    }

    public void LoadGame()
    {
        Game.Load();
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
