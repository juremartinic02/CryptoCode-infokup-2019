using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitRequest : MonoBehaviour
{

    // skripta koja poziva funkciju izlaženja iz igrice

    public void QuitRequestion()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
