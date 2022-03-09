using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public LayerMask groundMask;
    public Vector3 velocity;
    public float gravity = -19.62f;
    public bool checkGround;

    CharacterController playerController;
    Transform groundCheck;

    // Update is called once per frame
    void Update()
    { 
        playerController = GetComponent<CharacterController>();
        groundCheck = transform.GetChild(2);
        checkGround = Physics.CheckSphere(groundCheck.position, 0.4f, groundMask);

        if (checkGround && velocity.y < 0)
        {
            velocity.y = -2f; 
        }

        velocity.y += gravity * Time.deltaTime;

        playerController.Move(velocity * Time.deltaTime);
    }
}
