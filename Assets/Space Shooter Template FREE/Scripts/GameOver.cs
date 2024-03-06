using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string endMenuSceneName = "EndMenuScene";

    public void PlayerDied()
    {
        SceneManager.LoadScene("EndMenu");
    }
}
