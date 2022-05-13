using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    float sensitivity;
    PlayerLook playerLook; 

    void Start()
    {
        playerLook = GetComponent<PlayerLook>(); 
    }

    public void Back()
    {
        pauseMenu.SetActive(true);
        settingsMenu.SetActive(false); 
    }

    public void Save()
    {
        Data data = new Data(sensitivity);
        SaveMe.Save(data);
        playerLook.sensitivity = sensitivity; 
        Back(); 
    }

    public void ChangeSensitivity(float s)
    {
        sensitivity = s;
    }
}
