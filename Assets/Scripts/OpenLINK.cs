using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLINK : MonoBehaviour
{

    // skirpta kojom dajemo funkciju učitavanja URL-a sa interneta

    public void OpenLink()
    {
        Application.OpenURL("https://youtu.be/nKbF7xMIzgo");
    }
}
