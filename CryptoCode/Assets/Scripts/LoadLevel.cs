using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        NewMethod(sceneName);
    }

    private static void NewMethod(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
