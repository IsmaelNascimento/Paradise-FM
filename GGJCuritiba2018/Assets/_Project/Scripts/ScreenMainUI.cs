using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenMainUI : MonoBehaviour
{
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OnButtonExitGameClicked()
    {
        Application.Quit();
    }
}