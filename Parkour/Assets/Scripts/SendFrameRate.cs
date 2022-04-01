using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SendFrameRate : MonoBehaviour
{
    public Text frameRate;
    float deltaTime; 

    // Update is called once per frame
    void Update()
    {
        if (!(PauseMenu.isPaused))
        {
            deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
            float fps = 1.0f / deltaTime;
            frameRate.text = $"FPS: {Mathf.Ceil(fps)}";
        }
    }
}
