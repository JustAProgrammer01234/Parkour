using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu; 

    public void Back()
    {
        pauseMenu.SetActive(true);
        settingsMenu.SetActive(false); 
    }
}
