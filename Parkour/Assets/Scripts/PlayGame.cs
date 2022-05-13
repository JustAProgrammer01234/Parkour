using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayGame : MonoBehaviour
{
    public GameObject mainMenu; 
    public GameObject settingsMenu;

    float sensitivity;
    LoadSettingsData loadSettingsData; 

    void Start()
    {
        loadSettingsData = GetComponent<LoadSettingsData>(); 
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void Settings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);

        Data data = SaveMe.Load();
        loadSettingsData.LoadData(data); 
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void ChangeSensitivity(float s)
    {
        sensitivity = s; 
    }

    public void Save()
    {
        Data data = new Data(sensitivity);
        SaveMe.Save(data);
        Back(); 
    }
}
