using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public GameOver gameOver;

    // ...

    private void OnDestroy()
    {
        gameOver.PlayerDied();
    }
}
