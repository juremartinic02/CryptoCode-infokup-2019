using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Controller : MonoBehaviour
{
    public Text dolariText;

    void Update()
    {
        dolariText.text = GameVariables.Kune.ToString();
    }

    public void Plus()
    {
        GameVariables.Kune += 100;
    }

    public void Load()
    {
        GameVariables.LoadSaveData();
    }

    public void Save()
    {
        GameVariables.SaveData();
    }
}
