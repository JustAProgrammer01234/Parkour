using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController playerController;
    public float speed;

    Vector3 motion; 

    float verticalInput, horizontalInput;

    // Update is called once per frame
    void Update()
    {
        playerController = GetComponent<CharacterController>();

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        motion = transform.forward * verticalInput + transform.right * horizontalInput;

        playerController.Move(motion * speed * Time.deltaTime);
    }
}
