using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Potential error if there's a typo or syntax issue here

public class SettingsMenu : MonoBehaviour
{
    // Incorrect syntax can occur anywhere; method definitions, conditional statements, etc.
    public void GoToStartMenu()
    {
        SceneManager.LoadScene("StartMenu 1");
    }

        public void GoToTOS()
    {
        SceneManager.LoadScene("TOS");
    }


    public void GoToPrivacyPolicy()
    {
        SceneManager.LoadScene("PrivacyPolicy");
    }

}
