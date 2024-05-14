using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Nagrada : MonoBehaviour
{

    // skripta koja nam daje sumu novca nakon što se ulogiramo na vlastiti račun (napomena: nagrada se može pokupiti svakih 24h)

    public GameObject PrizeDisplay;

    public Text text;

    void Start()
    {
        text = PrizeDisplay.GetComponent<Text>();
        int reward = Random.Range(50, 200);
        text.text = "Prize: " + reward + " $";
        

        Game.TotalCash = Game.TotalCash + reward;
        Game.ResetChest();
        Game.Save();
    }


    void Prize()
    {
        int reward = Random.Range(50, 200);
        text.text = "Prize: " + reward + " $";

        Game.TotalCash = Game.TotalCash + reward;
        Game.ResetChest();
        Game.Save();
    }
}
