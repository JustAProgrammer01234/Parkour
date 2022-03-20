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
            StartCoroutine(GoToNextlevel());
        }
    }

    IEnumerator GoToNextlevel()
    {
        AsyncOperation loadScene = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        while (!loadScene.isDone)
        {
            yield return null; 
        }
    }
}
