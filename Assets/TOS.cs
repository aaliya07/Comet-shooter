using UnityEngine;
using UnityEngine.SceneManagement;

public class TOS : MonoBehaviour
{
    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings"); // Make sure "TOS" matches the name of your TOS scene exactly.
    }
}
