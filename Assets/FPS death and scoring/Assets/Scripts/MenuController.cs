using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    // skripta za postavljanje i zaključavanje pokazivača na sceni

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Hunter_Static.Load();
    }

    // postavljanje rezultata na sceni

    public void StartGame()
    {
        Hunter_Static.Score = 0;

        SceneManager.LoadScene("scene1");
    }
}
