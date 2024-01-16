using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void LoadEndMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
