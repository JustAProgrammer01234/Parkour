using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpHeight = 3f; 

    CharacterController playerController;
    Vector3 motion;
    bool checkGround; 
    float verticalInput, horizontalInput;
    float gravity;
    Vector3 crouch = new Vector3(1f, 0.5f, 1f); 

    // Update is called once per frame
    void Update()
    {
        playerController = GetComponent<CharacterController>();
        gravity = GetComponent<PlayerGravity>().gravity;
        checkGround = GetComponent<PlayerGravity>().checkGround; 

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        motion = transform.forward * verticalInput + transform.right * horizontalInput;

        if (Input.GetButtonDown("Jump") && checkGround)
        {
            GetComponent<PlayerGravity>().velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            transform.localScale = crouch; 
        }
        else if (Input.GetButtonUp("Fire3"))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }


        playerController.Move(motion * speed * Time.deltaTime);
    }
}
