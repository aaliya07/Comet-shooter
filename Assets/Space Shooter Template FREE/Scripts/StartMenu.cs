using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene("Level 2");
    }

        public void ShowSettings()
    {
        // Load the game scene
        SceneManager.LoadScene("Settings");
    }
}