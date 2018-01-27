using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowMenu : MonoBehaviour
{
    public void OnButtonMenuClicked(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void OnButtonContinueClicked(GameObject windowMenu)
    {
        windowMenu.SetActive(false);
    }

    public void OnButtonSetupClicked()
    {

    }

    public void OnButtonHomeClicked(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}
