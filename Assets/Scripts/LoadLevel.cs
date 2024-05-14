using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    // funkcija koja se korsiti pri mijenjanju scena
    public void ChangeScene(string sceneName)
    {
        NewMethod(sceneName);
    }

    private static void NewMethod(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
