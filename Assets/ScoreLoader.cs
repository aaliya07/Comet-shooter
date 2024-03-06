using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadTOS()
    {
        SceneManager.LoadScene("TOS"); // Make sure "TOS" matches the name of your TOS scene exactly.
    }
}
