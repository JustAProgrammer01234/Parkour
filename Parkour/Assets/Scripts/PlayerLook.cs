using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float sensitivity;
    public Transform playerCamera;

    float mouseX, mouseY; 
    float cameraRotation; 

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        playerCamera = transform.GetChild(0);

        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        cameraRotation -= mouseY;
        cameraRotation = Mathf.Clamp(cameraRotation, -90f, 90f);

        transform.Rotate(Vector3.up * mouseX);
        playerCamera.localRotation = Quaternion.Euler(cameraRotation, 0f, 0f); 
    }
}
