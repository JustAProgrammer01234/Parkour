using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DeathFloor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(6);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; 
    }
}
