using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextLevel : MonoBehaviour
{
    bool isCollided = false; 

    void Update()
    {
        isCollided = false; 
    }

    void OnTriggerEnter(Collider collision)
    {
        if (!isCollided)
        {
            int scenes = SceneManager.sceneCountInBuildSettings;
            int buildIndex = SceneManager.GetActiveScene().buildIndex + 1;

            if (((scenes - 1) - buildIndex) == 1)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true; 
            }

            SceneManager.LoadScene(buildIndex);
            isCollided = true; 
        }
    }
}
