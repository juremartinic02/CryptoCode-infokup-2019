using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathByPikachu : MonoBehaviour
{

    // skripta koja se aktivira ukoliko prefab Pikachu-a dodirne igrača a, time se igra prekida i igraču dodjeluje sumu novca koju je zaradio igrajuči igru

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Destroy")
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
