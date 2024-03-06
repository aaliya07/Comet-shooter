using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void LoadEndMenu()
    {
        SceneManager.LoadScene("EndMenu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartMenu 1");
    }

}
